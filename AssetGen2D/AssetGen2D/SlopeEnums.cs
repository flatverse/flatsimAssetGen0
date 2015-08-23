using System;

namespace flatsim.AssetGen2D
{
/*
 *       NW
 *     W /\ N
 *  SW__/\/\__NE
 *      \/\/
 *     S \/ E
 *       SE
 */  

    public enum Facing
    {
        NONE,

        NORTH,
        NORTHEAST,
        EAST,
        SOUTHEAST,
        SOUTH,
        SOUTHWEST,
        WEST,
        NORTHWEST
    }

    public enum SlopeType
    {
        FULL,
        TOPHALF,
        BOTTOMHALF,
        VALLEY,
        RIDGE
    }
}