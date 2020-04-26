using System;
using System.Net.Mime;
using SkiaSharp;

namespace Drakon.App.Renderers.InnerTypes
{
    public class CacheableSurface
    {
        private SKSurface _surface;

        /// <summary>
        /// Indicates that Surface has changed
        /// </summary>
        public bool IsDirty { get; set; }

        /// <summary>
        /// Currenst surface
        /// </summary>
        public SKSurface Surface
        {
            get => _surface;
            set
            {
                if (value != _surface && value != null)
                {
                    _surface = value;
                    IsDirty = true;
                }
            }
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public CacheableSurface()
        {
            IsDirty = false;
            _surface = default;
        }

        /// <summary>
        /// Creates new surface with specified sizes
        /// </summary>
        /// <param name="width">Surface width</param>
        /// <param name="height">Surface height</param>
        public void CreateNew(int width, int height, IntPtr holdingBufferPtr)
        {
            //if(!IsDirty || _surface == null)
            Surface = SKSurface.Create(new SKImageInfo(width,
                height, SKColorType.Rgba8888, SKAlphaType.Premul), holdingBufferPtr);
        }

        /// <summary>
        /// Clears created surface
        /// </summary>
        public void Clear()
        {
            _surface.Dispose();
        }

        // TODO: Implement caching methods here
    }
}