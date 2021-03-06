﻿// This source is subject to the MIT License.
// Please see https://github.com/frederiksen/Task-Card-Creator for details.
// All other rights reserved.

using System;
using System.Drawing;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media.Imaging;

namespace TFSQueryServices
{
  public static class DisplayImage
  {
    public static BitmapSource GetImageSource(Bitmap bitmap)
    {
      return Imaging.CreateBitmapSourceFromHBitmap(bitmap.GetHbitmap(),
          IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
    }
  }
}
