using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaWFA
{
    public static class Algoritmos
    {
        public static Bitmap applyFilterMatrix(Bitmap imagenAEditar, int[,] matrix)
        {
            Bitmap edit = new Bitmap(imagenAEditar.Width, imagenAEditar.Height);
            Color pixelFiltro;
            for (int fY = 0; fY < imagenAEditar.Height; fY++)
            {
                for (int fX = 0; fX < imagenAEditar.Width; fX++)
                {
                    Color pixel = imagenAEditar.GetPixel(fX, fY);
                    Color nPixel = Color.FromArgb(pixel.R, pixel.R, pixel.R);
                    imagenAEditar.SetPixel(fX, fY, nPixel);
                }
            }

            int suma = 0;
            for (int y = 1; y < imagenAEditar.Height - 1; y++)
            {
                for (int x = 1; x < imagenAEditar.Width - 1; x++)
                {
                    suma = 0;
                    for (int pX = -1; pX < 2; pX++)
                    {
                        for (int pY = -1; pY < 2; pY++)
                        {

                            pixelFiltro = imagenAEditar.GetPixel(x + pX, y + pY);
                            suma += (pixelFiltro.R * matrix[pX + 1, pY + 1]);

                            //Color pxActual = imagenAEditar.GetPixel(x, y);
                        }
                    }

                    if (suma < 0)
                        suma = 0;
                    else if (suma > 250)
                        suma = 250;


                    edit.SetPixel(x, y, Color.FromArgb(suma, suma, suma));
                }

            }


            return edit;
        }


        public static Bitmap applyFilterMatrixColor(Bitmap imagenAEditar, int[,] matrix, int div)
        {
            Bitmap edit = new Bitmap(imagenAEditar.Width, imagenAEditar.Height);
            Color pixelFiltro;

            int sumaR = 0;
            int sumaG = 0;
            int sumaB = 0;

            for (int y = 1; y < imagenAEditar.Height - 1; y++)
            {
                for (int x = 1; x < imagenAEditar.Width - 1; x++)
                {
                    sumaR = 0;
                    for (int pX = -1; pX < 2; pX++)
                    {
                        for (int pY = -1; pY < 2; pY++)
                        {

                            pixelFiltro = imagenAEditar.GetPixel(x + pX, y + pY);
                            sumaR += (pixelFiltro.R * matrix[pX + 1, pY + 1]);

                            sumaR = sumaR / div;
                            //Color pxActual = imagenAEditar.GetPixel(x, y);
                        }
                    }

                    if (sumaR < 0)
                        sumaR = 0;
                    else if (sumaR > 250)
                        sumaR = 250;


                    sumaG = 0;
                    for (int pX = -1; pX < 2; pX++)
                    {
                        for (int pY = -1; pY < 2; pY++)
                        {

                            pixelFiltro = imagenAEditar.GetPixel(x + pX, y + pY);
                            sumaG += (pixelFiltro.G * matrix[pX + 1, pY + 1]);
                            sumaG = sumaG / div;
                            //Color pxActual = imagenAEditar.GetPixel(x, y);
                        }
                    }

                    if (sumaG < 0)
                        sumaG = 0;
                    else if (sumaG > 250)
                        sumaG = 250;


                    sumaB = 0;
                    for (int pX = -1; pX < 2; pX++)
                    {
                        for (int pY = -1; pY < 2; pY++)
                        {

                            pixelFiltro = imagenAEditar.GetPixel(x + pX, y + pY);
                            sumaB += (pixelFiltro.B * matrix[pX + 1, pY + 1]);
                            sumaB = sumaB / div;
                            //Color pxActual = imagenAEditar.GetPixel(x, y);
                        }
                    }

                    if (sumaB < 0)
                        sumaB = 0;
                    else if (sumaB > 250)
                        sumaB = 250;


                    edit.SetPixel(x, y, Color.FromArgb(sumaR, sumaG, sumaB));
                }

            }


            return edit;
        }


        public static Bitmap applyErosion(Bitmap imagenAEditar)
        {
            Bitmap edit = new Bitmap(imagenAEditar.Width, imagenAEditar.Height);
            Color pixelFiltro;
            Color pixelLum;

            //Pixel en el que estaremos
            double lumin = 0;
            //Para los pixeles alrededor
            double luminPix = 0;

            for (int y = 1; y < imagenAEditar.Height - 1; y++)
            {
                for (int x = 1; x < imagenAEditar.Width - 1; x++)
                {
                    //Pixel en el que estamos
                    pixelLum = imagenAEditar.GetPixel(x, y);
                    lumin = pixelLum.R * 0.299 + pixelLum.G * 0.587 + pixelLum.B * 0.114;
                    for (int pX = -1; pX < 2; pX++)
                    {
                        for (int pY = -1; pY < 2; pY++)
                        {
                            //checamos los pixeles alrededor
                            pixelFiltro = imagenAEditar.GetPixel(x + pX, y + pY);
                            luminPix = pixelFiltro.R * 0.299 + pixelFiltro.G * 0.587 + pixelFiltro.B * 0.114;
                            //si la luminosidad es mayor guardamos el pixel y el valor
                            if (luminPix > lumin) { lumin = luminPix; pixelLum = pixelFiltro; }

                        }
                    }

                    for (int pX = -1; pX < 2; pX++)
                    {
                        for (int pY = -1; pY < 2; pY++)
                        {
                            //una vez que tenemos el pixel con mayor
                            //luminosidad lo repetimos a los vecinos
                            edit.SetPixel(x, y, pixelLum);
                        }
                    }

                }

            }


            return edit;
        }


        public static Bitmap grayScaleVideo(Bitmap frameEditar)
        {

            for (int fY = 0; fY < frameEditar.Height; fY++)
            {
                for (int fX = 0; fX < frameEditar.Width; fX++)
                {
                    Color pixel = frameEditar.GetPixel(fX, fY);
                    Color nPixel = Color.FromArgb(pixel.R, pixel.R, pixel.R);
                    frameEditar.SetPixel(fX, fY, nPixel);
                }
            }

            return frameEditar;
        }

        public static Bitmap sepiaFilterVideo(Bitmap frameEditar)
        {
            for (int fY = 0; fY < frameEditar.Height; fY++)
            {
                for (int fX = 0; fX < frameEditar.Width; fX++)
                {
                    Color pixel = frameEditar.GetPixel(fX, fY);

                    int sr = (int)(0.393 * pixel.R + 0.769 * pixel.G + 0.189 * pixel.B);
                    int sg = (int)(0.349 * pixel.R + 0.686 * pixel.G + 0.168 * pixel.B);
                    int sb = (int)(0.272 * pixel.R + 0.534 * pixel.G + 0.131 * pixel.B);

                    var r = Math.Clamp(sr, 0, 255);
                    var g = Math.Clamp(sg, 0, 255);
                    var b = Math.Clamp(sb, 0, 255);

                    frameEditar.SetPixel(fX, fY, Color.FromArgb(r, g, b));

                }
            }

            return frameEditar;
        }

        public static Bitmap negativeFilterVideo(Bitmap frameEditar)
        {
            for (int y = 0; y < frameEditar.Height; y++)
            {
                for (int x = 0; x < frameEditar.Width; x++)
                {
                    Color pixel = frameEditar.GetPixel(x, y);

                    int r = 255 - pixel.R;
                    int g = 255 - pixel.G;
                    int b = 255 - pixel.B;

                    frameEditar.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }


            return frameEditar;
        }
    }

}
