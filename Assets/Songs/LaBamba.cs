
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaBamba : SongScript
{
    public override Song GetSong()
    {
        return new Song(
        3,
        4,
        new List<PlayNote> 
        {
          new PlayNote(Notes.F4, 9.787500000000001f, 0.15416666666666679f),
          new PlayNote(Notes.F4, 9.995833333333334f, 0.1416666666666675f),
          new PlayNote(Notes.F4, 10.200000000000001f, 0.15000000000000036f),
          new PlayNote(Notes.F4, 10.404166666666669f, 0.16249999999999964f),
          new PlayNote(Notes.F4, 10.608333333333334f, 0.2749999999999986f),
          new PlayNote(Notes.E4, 11.008333333333333f, 0.27916666666666856f),
          new PlayNote(Notes.C4, 11.408333333333333f, 0.3291666666666675f),
          new PlayNote(Notes.F4, 13.004166666666666f, 0.14583333333333393f),
          new PlayNote(Notes.F4, 13.204166666666666f, 0.13333333333333464f),
          new PlayNote(Notes.F4, 13.391666666666666f, 0.14166666666666927f),
          new PlayNote(Notes.F4, 13.595833333333335f, 0.15833333333333144f),
          new PlayNote(Notes.F4, 13.791666666666666f, 0.283333333333335f),
          new PlayNote(Notes.E4, 14.195833333333335f, 0.28333333333333144f),
          new PlayNote(Notes.C4, 14.591666666666667f, 0.2958333333333343f),
          new PlayNote(Notes.C4, 14.995833333333335f, 0.15833333333333144f),
          new PlayNote(Notes.C4, 15.195833333333335f, 0.12916666666666643f),
          new PlayNote(Notes.C4, 15.391666666666666f, 0.2375000000000007f),
          new PlayNote(Notes.D4, 15.816666666666666f, 0.283333333333335f),
          new PlayNote(Notes.B3, 16.212500000000002f, 0.2624999999999993f),
          new PlayNote(Notes.D4, 16.570833333333336f, 0.18333333333333002f),
          new PlayNote(Notes.F4, 16.791666666666668f, 0.18333333333333357f),
          new PlayNote(Notes.E4, 17.066666666666666f, 0.22916666666666785f),
          new PlayNote(Notes.D4, 17.341666666666665f, 0.1750000000000007f),
          new PlayNote(Notes.E4, 17.595833333333335f, 0.2666666666666657f),
          new PlayNote(Notes.C4, 17.991666666666667f, 0.2624999999999993f),
          new PlayNote(Notes.F4, 19.383333333333336f, 0.23333333333333073f),
          new PlayNote(Notes.F4, 19.683333333333337f, 0.21249999999999858f),
          new PlayNote(Notes.F4, 19.962500000000002f, 0.20833333333333215f),
          new PlayNote(Notes.F4, 20.245833333333337f, 0.1999999999999993f),
          new PlayNote(Notes.F4, 20.512500000000003f, 0.1999999999999993f),
          new PlayNote(Notes.E4, 20.77916666666667f, 0.22499999999999787f),
          new PlayNote(Notes.C4, 21.170833333333334f, 0.19583333333333286f),
          new PlayNote(Notes.C4, 21.40416666666667f, 0.12916666666666643f),
          new PlayNote(Notes.C4, 21.6f, 0.154166666666665f),
          new PlayNote(Notes.C4, 21.804166666666667f, 0.220833333333335f),
          new PlayNote(Notes.D4, 22.179166666666667f, 0.2958333333333343f),
          new PlayNote(Notes.B3, 22.595833333333335f, 0.29583333333333073f),
          new PlayNote(Notes.D4, 22.945833333333336f, 0.18333333333333002f),
          new PlayNote(Notes.F4, 23.1625f, 0.1875f),
          new PlayNote(Notes.E4, 23.395833333333336f, 0.15833333333333144f),
          new PlayNote(Notes.D4, 23.587500000000002f, 0.158333333333335f),
          new PlayNote(Notes.E4, 23.804166666666667f, 0.2958333333333343f),
          new PlayNote(Notes.C4, 24.1875f, 0.283333333333335f),
          new PlayNote(Notes.F4, 25.96666666666667f, 0.14166666666666572f),
          new PlayNote(Notes.F4, 26.170833333333334f, 0.29999999999999716f),
          new PlayNote(Notes.F4, 26.55f, 0.13333333333333286f),
          new PlayNote(Notes.F4, 26.75416666666667f, 0.14583333333333215f),
          new PlayNote(Notes.E4, 26.958333333333332f, 0.3625000000000007f),
          new PlayNote(Notes.C4, 27.39166666666667f, 0.2375000000000007f),
          new PlayNote(Notes.C4, 27.8f, 0.12083333333333357f),
          new PlayNote(Notes.C4, 27.995833333333334f, 0.1374999999999993f),
          new PlayNote(Notes.C4, 28.195833333333333f, 0.26666666666666927f),
          new PlayNote(Notes.D4, 28.59166666666667f, 0.2666666666666657f),
          new PlayNote(Notes.B3, 29.19166666666667f, 0.3166666666666629f),
          new PlayNote(Notes.D4, 29.59583333333333f, 0.27083333333333925f),
          new PlayNote(Notes.F4, 29.995833333333334f, 0.2583333333333364f),
          new PlayNote(Notes.E4, 30.39166666666667f, 0.24583333333333357f),
          new PlayNote(Notes.E4, 30.79166666666667f, 0.3333333333333286f),
          new PlayNote(Notes.C4, 31.200000000000003f, 0.2624999999999993f),
          new PlayNote(Notes.A3, 31.59583333333333f, 0.18333333333333712f),
          new PlayNote(Notes.G3, 31.81666666666667f, 0.2958333333333343f),
          new PlayNote(Notes.F4, 32.39166666666667f, 0.15416666666666146f),
          new PlayNote(Notes.F4, 32.59166666666667f, 0.13750000000000284f),
          new PlayNote(Notes.F4, 32.79166666666667f, 0.26249999999999574f),
          new PlayNote(Notes.F4, 33.1875f, 0.14166666666667282f),
          new PlayNote(Notes.F4, 33.3875f, 0.19583333333333286f),
          new PlayNote(Notes.E4, 33.6f, 0.1875f),
          new PlayNote(Notes.C4, 33.79166666666667f, 0.23333333333332718f),
          new PlayNote(Notes.F4, 35.59166666666667f, 0.12083333333333002f),
          new PlayNote(Notes.F4, 35.7875f, 0.13333333333333286f),
          new PlayNote(Notes.F4, 35.987500000000004f, 0.3374999999999986f),
          new PlayNote(Notes.F4, 36.4f, 0.125f),
          new PlayNote(Notes.F4, 36.583333333333336f, 0.18333333333333712f),
          new PlayNote(Notes.E4, 36.78333333333333f, 0.18333333333333712f),
          new PlayNote(Notes.C4, 36.983333333333334f, 0.12083333333333712f),
          new PlayNote(Notes.C4, 37.18333333333333f, 0.15416666666666856f),
          new PlayNote(Notes.C4, 37.39166666666667f, 0.55416666666666f),
          new PlayNote(Notes.A3, 37.987500000000004f, 0.19583333333332575f),
          new PlayNote(Notes.D4, 38.2125f, 0.2291666666666714f),
          new PlayNote(Notes.B3, 38.78333333333333f, 0.3958333333333428f),
          new PlayNote(Notes.D4, 39.18333333333334f, 0.3499999999999943f),
          new PlayNote(Notes.F4, 39.587500000000006f, 0.20416666666666572f),
          new PlayNote(Notes.E4, 39.795833333333334f, 0.2291666666666714f),
          new PlayNote(Notes.E4, 40.3875f, 0.3333333333333286f),
          new PlayNote(Notes.C4, 40.80833333333334f, 0.29999999999999716f),
          new PlayNote(Notes.A3, 41.19583333333333f, 0.20000000000000284f),
          new PlayNote(Notes.G3, 41.395833333333336f, 0.20416666666666572f),
          new PlayNote(Notes.C4, 43.1875f, 0.7791666666666686f),
          new PlayNote(Notes.A3, 43.991666666666674f, 0.6124999999999972f),
          new PlayNote(Notes.B3, 44.60416666666667f, 0.3958333333333286f),
          new PlayNote(Notes.G3, 45.0f, 0.23750000000000426f),
          new PlayNote(Notes.E4, 46.3875f, 0.7958333333333343f),
          new PlayNote(Notes.C4, 47.1875f, 0.6208333333333371f),
          new PlayNote(Notes.D4, 47.80833333333334f, 0.375f),
          new PlayNote(Notes.D4, 48.212500000000006f, 0.2291666666666643f),
          new PlayNote(Notes.E4, 49.57916666666667f, 0.7916666666666643f),
          new PlayNote(Notes.C4, 50.38333333333333f, 0.6083333333333414f),
          new PlayNote(Notes.D4, 50.991666666666674f, 0.3541666666666643f),
          new PlayNote(Notes.D4, 51.391666666666666f, 0.22500000000000142f),
          new PlayNote(Notes.C4, 52.791666666666664f, 1.4958333333333371f),
          new PlayNote(Notes.F4, 54.59166666666667f, 0.14166666666667282f),
          new PlayNote(Notes.F4, 54.7875f, 0.14999999999999858f),
          new PlayNote(Notes.F4, 54.987500000000004f, 0.14999999999999858f),
          new PlayNote(Notes.F4, 55.19166666666666f, 0.18333333333333712f),
          new PlayNote(Notes.F4, 55.40833333333334f, 0.32083333333332575f),
          new PlayNote(Notes.E4, 55.8125f, 0.2958333333333414f),
          new PlayNote(Notes.C4, 56.19583333333334f, 0.2916666666666643f),
          new PlayNote(Notes.F4, 57.7875f, 0.15416666666666146f),
          new PlayNote(Notes.F4, 57.99166666666667f, 0.17083333333333428f),
          new PlayNote(Notes.F4, 58.19583333333334f, 0.14999999999999858f),
          new PlayNote(Notes.F4, 58.400000000000006f, 0.16249999999999432f),
          new PlayNote(Notes.F4, 58.604166666666664f, 0.2541666666666771f),
          new PlayNote(Notes.E4, 58.99166666666667f, 0.2958333333333343f),
          new PlayNote(Notes.C4, 59.391666666666666f, 0.20000000000000284f),
          new PlayNote(Notes.C4, 59.79583333333334f, 0.13749999999999574f),
          new PlayNote(Notes.C4, 59.99166666666667f, 0.13749999999999574f),
          new PlayNote(Notes.C4, 60.19166666666666f, 0.20000000000000284f),
          new PlayNote(Notes.D4, 60.58333333333334f, 0.29583333333332007f),
          new PlayNote(Notes.B3, 60.99166666666667f, 0.2083333333333357f),
          new PlayNote(Notes.D4, 61.38333333333334f, 0.17499999999999716f),
          new PlayNote(Notes.F4, 61.59166666666667f, 0.20416666666667282f),
          new PlayNote(Notes.E4, 61.8125f, 0.22083333333333854f),
          new PlayNote(Notes.D4, 62.11666666666667f, 0.17083333333333428f),
          new PlayNote(Notes.E4, 62.375f, 0.19583333333333997f),
          new PlayNote(Notes.C4, 62.6f, 0.2541666666666629f),
          new PlayNote(Notes.F4, 64.19166666666666f, 0.24583333333333712f),
          new PlayNote(Notes.F4, 64.52916666666667f, 0.17916666666667425f),
          new PlayNote(Notes.F4, 64.78333333333335f, 0.1833333333333229f),
          new PlayNote(Notes.F4, 65.04583333333333f, 0.18333333333333712f),
          new PlayNote(Notes.F4, 65.30416666666666f, 0.1708333333333485f),
          new PlayNote(Notes.E4, 65.59583333333335f, 0.2458333333333229f),
          new PlayNote(Notes.C4, 65.97916666666667f, 0.17083333333333428f),
          new PlayNote(Notes.C4, 66.19583333333334f, 0.13333333333332575f),
          new PlayNote(Notes.C4, 66.39583333333334f, 0.14166666666666572f),
          new PlayNote(Notes.C4, 66.59583333333335f, 0.21666666666665435f),
          new PlayNote(Notes.D4, 66.9875f, 0.25833333333333997f),
          new PlayNote(Notes.B3, 67.37916666666666f, 0.23333333333333428f),
          new PlayNote(Notes.D4, 67.74583333333334f, 0.17499999999999716f),
          new PlayNote(Notes.F4, 67.97083333333335f, 0.1833333333333229f),
          new PlayNote(Notes.E4, 68.18333333333334f, 0.15833333333333144f),
          new PlayNote(Notes.D4, 68.39583333333334f, 0.17083333333332007f),
          new PlayNote(Notes.E4, 68.60416666666667f, 0.2958333333333343f),
          new PlayNote(Notes.C4, 68.9875f, 0.25833333333333997f),
          new PlayNote(Notes.F4, 94.99583333333334f, 0.13333333333332575f),
          new PlayNote(Notes.F4, 95.19166666666666f, 0.13750000000000284f),
          new PlayNote(Notes.F4, 95.3875f, 0.1458333333333428f),
          new PlayNote(Notes.F4, 95.59166666666667f, 0.15000000000000568f),
          new PlayNote(Notes.F4, 95.79166666666667f, 0.1666666666666714f),
          new PlayNote(Notes.E4, 95.99166666666667f, 0.30416666666667425f),
          new PlayNote(Notes.C4, 96.38333333333334f, 0.2458333333333229f),
          new PlayNote(Notes.F4, 97.79583333333335f, 0.13333333333332575f),
          new PlayNote(Notes.F4, 97.98333333333335f, 0.12083333333332291f),
          new PlayNote(Notes.F4, 98.18333333333334f, 0.1458333333333286f),
          new PlayNote(Notes.F4, 98.40833333333335f, 0.15416666666665435f),
          new PlayNote(Notes.F4, 98.59166666666667f, 0.2708333333333428f),
          new PlayNote(Notes.E4, 98.99166666666667f, 0.23333333333333428f),
          new PlayNote(Notes.C4, 99.39166666666667f, 0.24166666666667425f),
          new PlayNote(Notes.C4, 99.78333333333335f, 0.13750000000000284f),
          new PlayNote(Notes.C4, 100.00416666666666f, 0.1291666666666771f),
          new PlayNote(Notes.C4, 100.18333333333334f, 0.2083333333333286f),
          new PlayNote(Notes.D4, 100.58333333333334f, 0.21666666666666856f),
          new PlayNote(Notes.B3, 100.98750000000001f, 0.25833333333332575f),
          new PlayNote(Notes.D4, 101.37916666666666f, 0.18333333333333712f),
          new PlayNote(Notes.F4, 101.59583333333335f, 0.16249999999999432f),
          new PlayNote(Notes.E4, 101.8375f, 0.20416666666666572f),
          new PlayNote(Notes.D4, 102.15416666666667f, 0.17499999999999716f),
          new PlayNote(Notes.E4, 102.37916666666666f, 0.2083333333333428f),
          new PlayNote(Notes.C4, 102.78750000000001f, 0.23333333333332007f),
          new PlayNote(Notes.F4, 104.2125f, 0.28333333333333144f),
          new PlayNote(Notes.F4, 104.575f, 0.1458333333333286f),
          new PlayNote(Notes.F4, 104.775f, 0.1916666666666771f),
          new PlayNote(Notes.F4, 105.03333333333333f, 0.2083333333333428f),
          new PlayNote(Notes.F4, 105.30416666666667f, 0.17916666666666003f),
          new PlayNote(Notes.E4, 105.5875f, 0.22083333333333144f),
          new PlayNote(Notes.C4, 105.95f, 0.1666666666666714f),
          new PlayNote(Notes.C4, 106.2f, 0.12083333333332291f),
          new PlayNote(Notes.C4, 106.39583333333333f, 0.1291666666666771f),
          new PlayNote(Notes.C4, 106.56666666666668f, 0.23749999999999716f),
          new PlayNote(Notes.D4, 106.97083333333333f, 0.32916666666667993f),
          new PlayNote(Notes.B3, 107.37916666666668f, 0.19583333333332575f),
          new PlayNote(Notes.D4, 107.79166666666669f, 0.17916666666664582f),
          new PlayNote(Notes.F4, 107.99583333333334f, 0.15416666666666856f),
          new PlayNote(Notes.E4, 108.2f, 0.15416666666668277f),
          new PlayNote(Notes.D4, 108.38333333333333f, 0.17500000000001137f),
          new PlayNote(Notes.E4, 108.61250000000001f, 0.32499999999998863f),
          new PlayNote(Notes.C4, 108.99166666666667f, 0.24166666666666003f),
          new PlayNote(Notes.F4, 110.80000000000001f, 0.14166666666666572f),
          new PlayNote(Notes.F4, 110.99583333333334f, 0.2958333333333485f),
          new PlayNote(Notes.F4, 111.39166666666668f, 0.1458333333333286f),
          new PlayNote(Notes.F4, 111.59166666666668f, 0.17916666666664582f),
          new PlayNote(Notes.E4, 111.79583333333333f, 0.3291666666666657f),
          new PlayNote(Notes.C4, 112.17500000000001f, 0.29583333333332007f),
          new PlayNote(Notes.C4, 112.59583333333333f, 0.125f),
          new PlayNote(Notes.C4, 112.8125f, 0.13750000000000284f),
          new PlayNote(Notes.C4, 112.99583333333334f, 0.2749999999999915f),
          new PlayNote(Notes.D4, 113.39166666666668f, 0.2458333333333229f),
          new PlayNote(Notes.B3, 114.00416666666668f, 0.29999999999999716f),
          new PlayNote(Notes.D4, 114.38333333333333f, 0.2958333333333485f),
          new PlayNote(Notes.F4, 114.79166666666669f, 0.34166666666664014f),
          new PlayNote(Notes.E4, 115.20416666666668f, 0.21666666666665435f),
          new PlayNote(Notes.E4, 115.60000000000001f, 0.29999999999999716f),
          new PlayNote(Notes.C4, 115.99166666666667f, 0.25833333333332575f),
          new PlayNote(Notes.A3, 116.39166666666668f, 0.2041666666666515f),
          new PlayNote(Notes.G3, 116.59583333333333f, 0.24166666666667425f),
          new PlayNote(Notes.C4, 118.3875f, 0.7916666666666714f),
          new PlayNote(Notes.A3, 119.19583333333333f, 0.6125000000000114f),
          new PlayNote(Notes.B3, 119.80833333333334f, 0.3791666666666629f),
          new PlayNote(Notes.G3, 120.20416666666668f, 0.2291666666666572f),
          new PlayNote(Notes.E4, 121.59166666666668f, 0.7749999999999915f),
          new PlayNote(Notes.C4, 122.41250000000001f, 0.5958333333333172f),
          new PlayNote(Notes.D4, 122.98750000000001f, 0.32499999999998863f),
          new PlayNote(Notes.D4, 123.39166666666668f, 0.25833333333332575f),
          new PlayNote(Notes.E4, 124.80000000000001f, 0.7708333333333144f),
          new PlayNote(Notes.C4, 125.59166666666668f, 0.604166666666643f),
          new PlayNote(Notes.D4, 126.19583333333333f, 0.3416666666666828f),

        }
        );
    }
}