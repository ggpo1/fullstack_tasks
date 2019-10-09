using FullStackLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullStackLibrary.Interfaces
{
    public interface IFullStackLibrary
    {
        double GetCircleSquare(Circle circle);
        double GetTriangleSquare(Triangle circle);
    }
}
