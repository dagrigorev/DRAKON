using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Drakon.App.Renderers.InnerTypes;
using Drakon.Core.Common.ObservableBase;
using Prism.Mvvm;
using SkiaSharp;

namespace Drakon.App.Renderers
{
    /// <summary>
    /// Skia renderer implementation
    /// </summary>
    public class SkiaImageRenderer : Observable, IImageRenderer
    {
        private int _framesPerSecond;
        private int _framesCount;
        private Stopwatch _stopwatch;
        private CacheableSurface _surface;
        private ISet<Action<SKCanvas>> _renderActions;

        /// <inheritdoc />
        public int FramesCount
        {
            get => _framesCount;
            set => SetProperty(ref _framesCount, value);
        }

        /// <inheritdoc />
        public int FramesPerSecond
        {
            get => _framesPerSecond;
            set => SetProperty(ref _framesPerSecond, value);
        }

        /// <inheritdoc />
        public SKCanvas Canvas => _surface?.Surface?.Canvas;

        /// <summary>
        /// Default constructor
        /// </summary>
        public SkiaImageRenderer()
        {
            _stopwatch = new Stopwatch();
            _framesCount = 0;
            _framesPerSecond = 0;
            _surface = new CacheableSurface();
            _renderActions = new HashSet<Action<SKCanvas>>();
        }

        /// <inheritdoc />
        public WriteableBitmap CreateImage(int width, int height)
        {
            return new WriteableBitmap(width, height, 96, 96, PixelFormats.Bgra32, BitmapPalettes.Halftone256Transparent);
        }

        /// <inheritdoc />
        public void UpdateImage(WriteableBitmap writeableBitmap)
        {
            BeginRender(writeableBitmap);
            UpdateRendererState();

            ExecuteRenderSequence(_surface.Surface.Canvas);

            EndRender(writeableBitmap);
        }

        /// <inheritdoc />
        public void AddRenderAction(Action<SKCanvas> action)
        {
            if (!_renderActions.Contains(action))
                _renderActions.Add(action);
        }

        /// <inheritdoc />
        public void RemoveRenderAction(Action<SKCanvas> action)
        {
            if (_renderActions.Contains(action))
                _renderActions.Remove(action);
        }

        /// <summary>
        /// Updates renderer state before starting render
        /// </summary>
        private void UpdateRendererState()
        {
            if (FramesCount == 0)
                _stopwatch.Start();

            FramesPerSecond = (int)(FramesCount /
                                    ((Math.Abs(_stopwatch.Elapsed.TotalSeconds) > 0.5) ?
                                        _stopwatch.Elapsed.TotalSeconds : 1));
        }

        /// <summary>
        /// Begins rendering
        /// </summary>
        /// <param name="writeableBitmap"></param>
        private void BeginRender(WriteableBitmap writeableBitmap)
        {
            writeableBitmap.Lock();

            _surface.CreateNew((int)writeableBitmap.Width, (int)writeableBitmap.Height, writeableBitmap.BackBuffer);
            _surface.Surface.Canvas.Clear(new SKColor(255, 255, 255));
        }

        /// <summary>
        /// Ends rendering
        /// </summary>
        /// <param name="writeableBitmap"></param>
        private void EndRender(WriteableBitmap writeableBitmap)
        {
            _surface.Clear();

            writeableBitmap.AddDirtyRect(new Int32Rect(0, 0,
                (int)writeableBitmap.Width,
                (int)writeableBitmap.Height));
            writeableBitmap.Unlock();
        }

        /// <summary>
        /// Executes all registered render actions as sequence
        /// </summary>
        /// <param name="canvas"></param>
        private void ExecuteRenderSequence(SKCanvas canvas)
        {
            // TODO: Check for render tasks scheduling
            foreach (var action in _renderActions)
                action?.Invoke(canvas);
        }
    }
}