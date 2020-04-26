using System;
using System.Windows.Media.Imaging;
using Drakon.Core.Common.ObservableBase;
using SkiaSharp;

namespace Drakon.App.Renderers
{
  /// <summary>
  /// WPF Image renderer contract
  /// </summary>
  public interface IImageRenderer : IObservable
  {
      /// <summary>
      /// Rendered frames count
      /// </summary>
      public int FramesCount { get; set; }

      /// <summary>
      /// FPS counter
      /// </summary>
      public int FramesPerSecond { get; set; }

      /// <summary>
      /// Returns current scene 
      /// </summary>
      public SKCanvas Canvas { get; }

      /// <summary>
      /// Creates new writeable image
      /// </summary>
      /// <param name="width">Image width</param>
      /// <param name="height">Image height</param>
      /// <returns></returns>
      WriteableBitmap CreateImage(int width, int height);

      /// <summary>
      /// Updates writeable image
      /// </summary>
      /// <param name="writeableBitmap">Image that needs to be updated immediately</param>
      void UpdateImage(WriteableBitmap writeableBitmap);

      /// <summary>
      /// Adds new rendering step
      /// </summary>
      /// <param name="action"></param>
      void AddRenderAction(Action<SKCanvas> action);

      /// <summary>
      /// Removes rendering step
      /// </summary>
      /// <param name="action"></param>
      void RemoveRenderAction(Action<SKCanvas> action);
  }
}