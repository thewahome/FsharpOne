open System.Drawing
open System.IO
open System

let path = __SOURCE_DIRECTORY__ + "\\bitmaps\\"
let pathAndFilename = Path.Combine(path,"accuracy.png")
let bitmap = new Bitmap(32,32)
bitmap.SetPixel(int 10.1,2,Color.Black)
bitmap.SetPixel(int 10.2,3,Color.Black)
bitmap.SetPixel(int (Math.Round(10.4)),4,Color.Black)
bitmap.SetPixel(int (Math.Round(10.6)),5,Color.Black)
bitmap.SetPixel(int 10.8,6,Color.Black)
bitmap.SetPixel(int 10.9,7,Color.Black)
bitmap.SetPixel(int 10.99,8,Color.Black)
bitmap.SetPixel(int 10.999,9,Color.Black)
bitmap.SetPixel(int 10.9999,10,Color.Black)
bitmap.SetPixel(int 11.0,11,Color.Blue)
bitmap.Save(pathAndFilename)
