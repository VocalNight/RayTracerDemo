using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace RayTracer;

public class RayTracerService
{

    const float EPSILON = 0.00001f;

    public bool IsPoint( (double x, double y, double z, double w) value )
    {
        if (value.w == 1.0)
        {
            return true;
        }

        return false;
    }

    public (float x, float y, float z, float w) PointFactory( (float x, float y, float z) point )
    {
        return (point.x, point.y, point.z, 1.0f);

    }

    public (float x, float y, float z, float w) VectorFactory( (float x, float y, float z) vector )
    {
        return (vector.x, vector.y, vector.z, 0.0f);
    }

    public bool CompareFloats( float a, float b )
    {
        if (a - b < EPSILON)
        {
            return true;
        }

        return false;

    }

    public bool CompareTuples( (float x, float y, float z, float w) tuple1, (float x, float y, float z, float w) tuple2 )
    {
        return tuple1 == tuple2;
    }

    public (float x, float y, float z, float w) AddTuple( (float x, float y, float z, float w) tuple1, (float x, float y, float z, float w) tuple2 )
    {
        (float x, float y, float z, float w) newPoint = (tuple1.x + tuple2.x, tuple1.y + tuple2.y, tuple1.z + tuple2.z, tuple1.y + tuple2.y);
        return newPoint;
    }
}