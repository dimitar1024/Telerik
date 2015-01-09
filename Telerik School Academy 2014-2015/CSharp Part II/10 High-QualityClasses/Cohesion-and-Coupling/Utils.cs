﻿using System;

namespace CohesionAndCoupling
{
    static class Utils
    {
        public static double Width { get; set; }
        public static double Height { get; set; }
        public static double Depth { get; set; }

        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return "";
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }

        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return distance;
        }

        public static double CalcVolume(double width, double height, double depth)
        {
            double volume = width * height * depth;
            return volume;
        }

        public static double CalcDiagonalXYZ(double startX, double startY,double startZ, double width, double height, double depth)
        {
            double distance = CalcDistance3D(startX,startY,startZ,width,height,depth);
            return distance;
        }

        public static double CalcDiagonalXY(double startX, double startY, double width, double height)
        {
            double distance = CalcDistance2D(startX,startY,width,height);
            return distance;
        }

        public static double CalcDiagonalXZ(double startX, double startY, double width, double depth)
        {
            double distance = CalcDistance2D(startX, startY, width, depth);
            return distance;
        }

        public static double CalcDiagonalYZ(double startX, double startY, double height, double depth)
        {
            double distance = CalcDistance2D(startX, startY, height, depth);
            return distance;
        }
    }
}
