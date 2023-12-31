
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sing : SongScript
{
    public override Song GetSong()
    {
        return new Song(
        2,
        19,
        new List<PlayNote> 
        {
          new PlayNote(Notes.G4, 17.64704f, 1.760108416666668f),
          new PlayNote(Notes.G4, 20.294096f, 0.21599241666666913f),
          new PlayNote(Notes.G4, 20.514684f, 0.21599241666666913f),
          new PlayNote(Notes.As4, 20.735272000000002f, 0.4365804166666649f),
          new PlayNote(Notes.Gs4, 21.176448f, 1.760108416666668f),
          new PlayNote(Notes.Gs4, 23.823504f, 0.21599241666666913f),
          new PlayNote(Notes.Gs4, 24.044092f, 0.21599241666666913f),
          new PlayNote(Notes.C5, 24.264680000000002f, 0.4365804166666649f),
          new PlayNote(Notes.As4, 24.705856f, 1.760108416666668f),
          new PlayNote(Notes.As4, 27.352912f, 0.21599241666666913f),
          new PlayNote(Notes.As4, 27.5735f, 0.21599241666666913f),
          new PlayNote(Notes.Ds5, 27.794088000000002f, 0.8777564166666636f),
          new PlayNote(Notes.Cs5, 28.67644f, 2.2012844166666667f),
          new PlayNote(Notes.C5, 32.205848f, 0.8777564166666636f),
          new PlayNote(Notes.C5, 33.0882f, 0.4365804166666649f),
          new PlayNote(Notes.C5, 33.529376f, 0.4365804166666649f),
          new PlayNote(Notes.Ds5, 33.970552f, 0.8777564166666707f),
          new PlayNote(Notes.G4, 34.852904f, 0.4365804166666649f),
          new PlayNote(Notes.As4, 35.29408f, 1.760108416666668f),
          new PlayNote(Notes.Ds5, 39.264664f, 0.8777564166666636f),
          new PlayNote(Notes.Ds5, 40.147016f, 0.4365804166666649f),
          new PlayNote(Notes.Ds5, 40.588192f, 0.4365804166666649f),
          new PlayNote(Notes.G5, 41.029368f, 0.8777564166666707f),
          new PlayNote(Notes.F4, 41.91172f, 0.4365804166666649f),
          new PlayNote(Notes.Gs4, 42.352896f, 1.760108416666668f),
          new PlayNote(Notes.G4, 45.882304000000005f, 1.760108416666661f),
          new PlayNote(Notes.G4, 48.529360000000004f, 0.21599241666665847f),
          new PlayNote(Notes.G4, 48.749948f, 0.21599241666666558f),
          new PlayNote(Notes.As4, 48.970536f, 0.4365804166666649f),
          new PlayNote(Notes.Gs4, 49.411712f, 1.760108416666668f),
          new PlayNote(Notes.Gs4, 52.058768f, 0.4365804166666649f),
          new PlayNote(Notes.C5, 52.499944f, 0.4365804166666649f),
          new PlayNote(Notes.As4, 52.94112f, 0.4365804166666649f),
          new PlayNote(Notes.As4, 53.382296000000004f, 0.8777564166666636f),
          new PlayNote(Notes.G4, 54.264648f, 0.4365804166666649f),
          new PlayNote(Notes.As4, 54.705824f, 0.4365804166666649f),
          new PlayNote(Notes.Ds5, 55.147f, 0.4365804166666649f),
          new PlayNote(Notes.Gs5, 55.588176000000004f, 0.4365804166666649f),
          new PlayNote(Notes.G5, 56.029352f, 0.8777564166666707f),
          new PlayNote(Notes.F5, 56.911704f, 2.6424604166666725f),
          new PlayNote(Notes.Ds5, 59.55876f, 0.436580416666672f),
          new PlayNote(Notes.G5, 59.999936000000005f, 0.21599241666666558f),
          new PlayNote(Notes.G5, 60.220524000000005f, 0.21599241666666558f),
          new PlayNote(Notes.F5, 60.441112000000004f, 0.436580416666672f),
          new PlayNote(Notes.Ds5, 60.882288f, 0.436580416666672f),
          new PlayNote(Notes.F5, 61.323464f, 0.436580416666672f),
          new PlayNote(Notes.G5, 61.76464f, 0.436580416666672f),
          new PlayNote(Notes.F5, 62.205816f, 0.21599241666667268f),
          new PlayNote(Notes.Ds5, 62.426404000000005f, 0.4365804166666649f),
          new PlayNote(Notes.F5, 63.308756f, 0.21599241666667268f),
          new PlayNote(Notes.G5, 63.529344f, 0.21599241666667268f),
          new PlayNote(Notes.G5, 63.749932f, 0.21599241666667268f),
          new PlayNote(Notes.F5, 63.97052f, 0.4365804166666791f),
          new PlayNote(Notes.Ds5, 64.411696f, 0.436580416666672f),
          new PlayNote(Notes.D5, 64.852872f, 0.436580416666672f),
          new PlayNote(Notes.C5, 65.294048f, 1.3189324166666694f),
          new PlayNote(Notes.G4, 66.617576f, 0.436580416666672f),
          new PlayNote(Notes.As4, 67.058752f, 1.760108416666668f),
          new PlayNote(Notes.As4, 69.705808f, 0.21599241666666558f),
          new PlayNote(Notes.As4, 69.926396f, 0.2159924166666798f),
          new PlayNote(Notes.F5, 70.146984f, 0.436580416666672f),
          new PlayNote(Notes.Ds5, 70.58816f, 3.524812416666677f),
          new PlayNote(Notes.G5, 77.646976f, 0.436580416666672f),
          new PlayNote(Notes.G5, 78.08815200000001f, 0.21599241666666558f),
          new PlayNote(Notes.E5, 78.30874f, 0.2159924166666798f),
          new PlayNote(Notes.G5, 78.529328f, 0.21599241666666558f),
          new PlayNote(Notes.A5, 78.749916f, 0.436580416666672f),
          new PlayNote(Notes.E5, 79.191092f, 0.2159924166666798f),
          new PlayNote(Notes.G5, 79.41168f, 0.436580416666672f),
          new PlayNote(Notes.G5, 79.852856f, 0.21599241666666558f),
          new PlayNote(Notes.E5, 80.07344400000001f, 0.21599241666666558f),
          new PlayNote(Notes.G5, 80.294032f, 0.21599241666666558f),
          new PlayNote(Notes.A5, 80.51462000000001f, 0.436580416666672f),
          new PlayNote(Notes.E5, 80.955796f, 0.21599241666666558f),
          new PlayNote(Notes.F5, 81.176384f, 0.436580416666672f),
          new PlayNote(Notes.G5, 81.61756f, 0.436580416666672f),
          new PlayNote(Notes.F5, 82.058736f, 0.2159924166666798f),
          new PlayNote(Notes.E5, 82.279324f, 0.21599241666666558f),
          new PlayNote(Notes.D5, 82.49991200000001f, 0.21599241666666558f),
          new PlayNote(Notes.G4, 82.7205f, 1.5395204166666758f),
          new PlayNote(Notes.E5, 84.705792f, 1.760108416666668f),
          new PlayNote(Notes.E5, 87.35284800000001f, 0.21599241666666558f),
          new PlayNote(Notes.G5, 87.573436f, 0.6571684166666785f),
          new PlayNote(Notes.F5, 88.2352f, 1.760108416666668f),
          new PlayNote(Notes.F5, 90.882256f, 0.436580416666672f),
          new PlayNote(Notes.A5, 91.323432f, 0.436580416666672f),
          new PlayNote(Notes.G5, 91.76460800000001f, 1.760108416666668f),
          new PlayNote(Notes.G5, 94.411664f, 0.436580416666672f),
          new PlayNote(Notes.C6, 94.85284f, 0.436580416666672f),
          new PlayNote(Notes.As5, 95.294016f, 2.6424604166666796f),
          new PlayNote(Notes.A5, 99.2646f, 0.8777564166666707f),
          new PlayNote(Notes.A5, 100.146952f, 0.436580416666672f),
          new PlayNote(Notes.A5, 100.588128f, 0.436580416666672f),
          new PlayNote(Notes.C6, 101.029304f, 0.8777564166666707f),
          new PlayNote(Notes.E5, 101.91165600000001f, 0.436580416666672f),
          new PlayNote(Notes.G5, 102.352832f, 1.760108416666668f),
          new PlayNote(Notes.C6, 106.32341600000001f, 0.8777564166666707f),
          new PlayNote(Notes.C6, 107.205768f, 0.436580416666672f),
          new PlayNote(Notes.C6, 107.646944f, 0.436580416666672f),
          new PlayNote(Notes.E6, 108.08812f, 0.8777564166666707f),
          new PlayNote(Notes.D5, 108.970472f, 0.436580416666672f),
          new PlayNote(Notes.F5, 109.411648f, 1.760108416666668f),
          new PlayNote(Notes.G4, 112.941056f, 1.7601084166666539f),
          new PlayNote(Notes.G4, 115.58811200000001f, 0.21599241666665137f),
          new PlayNote(Notes.G4, 115.8087f, 0.21599241666666558f),
          new PlayNote(Notes.As4, 116.02928800000001f, 0.4365804166666578f),
          new PlayNote(Notes.Gs4, 116.470464f, 1.7601084166666539f),
          new PlayNote(Notes.Gs4, 119.11752f, 0.4365804166666578f),
          new PlayNote(Notes.C5, 119.558696f, 0.4365804166666578f),
          new PlayNote(Notes.As4, 119.99987200000001f, 0.4365804166666578f),
          new PlayNote(Notes.As4, 120.44104800000001f, 0.8777564166666565f),
          new PlayNote(Notes.G4, 121.3234f, 0.4365804166666578f),
          new PlayNote(Notes.As4, 121.764576f, 0.4365804166666578f),
          new PlayNote(Notes.Ds5, 122.205752f, 0.4365804166666578f),
          new PlayNote(Notes.Gs5, 122.646928f, 0.4365804166666578f),
          new PlayNote(Notes.G5, 123.088104f, 0.8777564166666565f),
          new PlayNote(Notes.F5, 123.970456f, 2.6424604166666654f),
          new PlayNote(Notes.Ds5, 126.617512f, 0.4365804166666578f),
          new PlayNote(Notes.G5, 127.058688f, 0.21599241666665137f),
          new PlayNote(Notes.G5, 127.27927600000001f, 0.21599241666665137f),
          new PlayNote(Notes.F5, 127.499864f, 0.21599241666666558f),
          new PlayNote(Notes.Ds5, 127.94104f, 0.21599241666665137f),
          new PlayNote(Notes.F5, 128.382216f, 0.21599241666666558f),
          new PlayNote(Notes.G5, 128.823392f, 0.4365804166666578f),
          new PlayNote(Notes.F5, 129.264568f, 0.21599241666666558f),
          new PlayNote(Notes.Ds5, 129.48515600000002f, 0.4365804166666578f),
          new PlayNote(Notes.F5, 130.36750800000002f, 0.21599241666663715f),
          new PlayNote(Notes.G5, 130.588096f, 0.2331346875000122f),
          new PlayNote(Notes.G5, 130.826191f, 0.2331346875000122f),
          new PlayNote(Notes.F5, 131.064286f, 0.511853072916665f),
          new PlayNote(Notes.Ds5, 131.58152700000002f, 0.5601417708333258f),
          new PlayNote(Notes.D5, 132.14756500000001f, 0.6184895833333428f),
          new PlayNote(Notes.C5, 132.77256500000001f, 1.7369175624999968f),
          new PlayNote(Notes.G4, 134.865587f, 0.7939128020833266f),
          new PlayNote(Notes.As4, 135.6689695f, 1.760108416666668f),
          new PlayNote(Notes.As4, 138.3160255f, 0.21599241666666558f),
          new PlayNote(Notes.As4, 138.53661350000002f, 0.21599241666666558f),
          new PlayNote(Notes.F5, 138.7572015f, 0.4365804166666578f),
          new PlayNote(Notes.Ds5, 139.1983775f, 3.0836364166666783f),
          new PlayNote(Notes.C5, 142.2866095f, 0.43658041666668623f),
          new PlayNote(Notes.As4, 142.7277855f, 2.6424604166666654f),
          new PlayNote(Notes.As4, 145.3748415f, 0.4365804166666578f),
          new PlayNote(Notes.F5, 145.81601750000002f, 0.4365804166666578f),
          new PlayNote(Notes.Ds5, 146.2571935f, 3.0836364166666783f),
          new PlayNote(Notes.C5, 149.3454255f, 0.4365804166666578f),
          new PlayNote(Notes.As4, 149.78660150000002f, 2.6424604166666654f),
          new PlayNote(Notes.As4, 152.4336575f, 0.21599241666666558f),
          new PlayNote(Notes.As4, 152.6542455f, 0.21599241666666558f),
          new PlayNote(Notes.F5, 152.8748335f, 0.43658041666668623f),
          new PlayNote(Notes.Ds5, 153.3160095f, 5.179222416666676f),
          new PlayNote(Notes.As5, 167.4336415f, 0.3262864166666759f),
          new PlayNote(Notes.As5, 167.8748175f, 0.21599241666666558f),
          new PlayNote(Notes.G5, 168.0954055f, 0.10569841666668367f),
          new PlayNote(Notes.As5, 168.3159935f, 0.10569841666668367f),
          new PlayNote(Notes.C6, 168.5365815f, 0.3262864166666475f),
          new PlayNote(Notes.G5, 168.9777575f, 0.10569841666665525f),
          new PlayNote(Notes.As5, 169.19834550000002f, 0.3262864166666475f),
          new PlayNote(Notes.As5, 169.6395215f, 0.21599241666666558f),
          new PlayNote(Notes.G5, 169.86010950000002f, 0.10569841666665525f),
          new PlayNote(Notes.As5, 170.0806975f, 0.10569841666665525f),
          new PlayNote(Notes.C6, 170.3012855f, 0.3262864166666759f),
          new PlayNote(Notes.G5, 170.7424615f, 0.10569841666668367f),
          new PlayNote(Notes.Gs5, 170.9630495f, 0.3262864166666475f),
          new PlayNote(Notes.As5, 171.4042255f, 0.3262864166666759f),
          new PlayNote(Notes.Gs5, 171.8454015f, 0.21599241666666558f),
          new PlayNote(Notes.G5, 172.0659895f, 0.10569841666665525f),
          new PlayNote(Notes.F5, 172.28657750000002f, 0.10569841666665525f),
          new PlayNote(Notes.C5, 172.5071655f, 1.5395204166666474f),
          new PlayNote(Notes.As5, 174.4924575f, 0.3262864166666759f),
          new PlayNote(Notes.As5, 174.9336335f, 0.21599241666666558f),
          new PlayNote(Notes.G5, 175.1542215f, 0.10569841666665525f),
          new PlayNote(Notes.As5, 175.3748095f, 0.10569841666668367f),
          new PlayNote(Notes.C6, 175.5953975f, 0.3262864166666759f),
          new PlayNote(Notes.G5, 176.0365735f, 0.10569841666665525f),
          new PlayNote(Notes.As5, 176.2571615f, 0.3262864166666759f),
          new PlayNote(Notes.As5, 176.6983375f, 0.21599241666666558f),
          new PlayNote(Notes.G5, 176.9189255f, 0.10569841666665525f),
          new PlayNote(Notes.As5, 177.13951350000002f, 0.10569841666665525f),
          new PlayNote(Notes.C6, 177.3601015f, 0.3262864166666475f),
          new PlayNote(Notes.G5, 177.8012775f, 0.10569841666668367f),
          new PlayNote(Notes.Gs5, 178.0218655f, 0.3262864166666759f),
          new PlayNote(Notes.As5, 178.4630415f, 0.3262864166666759f),
          new PlayNote(Notes.Gs5, 178.90421750000002f, 0.21599241666666558f),
          new PlayNote(Notes.G5, 179.1248055f, 0.10569841666665525f),
          new PlayNote(Notes.F5, 179.3453935f, 0.10569841666665525f),
          new PlayNote(Notes.As4, 179.56598150000002f, 1.5395204166666474f),
          new PlayNote(Notes.As5, 181.5512735f, 0.3262864166666475f),
          new PlayNote(Notes.As5, 181.99244950000002f, 0.21599241666666558f),
          new PlayNote(Notes.G5, 182.2130375f, 0.10569841666665525f),
          new PlayNote(Notes.As5, 182.4336255f, 0.10569841666665525f),
          new PlayNote(Notes.C6, 182.6542135f, 0.3262864166666759f),
          new PlayNote(Notes.G5, 183.0953895f, 0.10569841666665525f),
          new PlayNote(Notes.As5, 183.3159775f, 0.3262864166666759f),
          new PlayNote(Notes.As5, 183.75715350000002f, 0.21599241666666558f),
          new PlayNote(Notes.G5, 183.9777415f, 0.10569841666665525f),
          new PlayNote(Notes.As5, 184.1983295f, 0.10569841666665525f),
          new PlayNote(Notes.C6, 184.41891750000002f, 0.3262864166666475f),
          new PlayNote(Notes.G5, 184.8600935f, 0.10569841666665525f),
          new PlayNote(Notes.Gs5, 185.0806815f, 0.3262864166666759f),
          new PlayNote(Notes.As5, 185.5218575f, 0.3262864166666759f),
          new PlayNote(Notes.Gs5, 185.9630335f, 0.21599241666666558f),
          new PlayNote(Notes.G5, 186.18362150000002f, 0.10569841666665525f),
          new PlayNote(Notes.F5, 186.4042095f, 0.10569841666665525f),
          new PlayNote(Notes.C5, 186.6247975f, 1.5395204166666758f),
          new PlayNote(Notes.As5, 188.61008950000002f, 0.3262864166666475f),
          new PlayNote(Notes.As5, 189.0512655f, 0.21599241666666558f),
          new PlayNote(Notes.G5, 189.27185350000002f, 0.10569841666665525f),
          new PlayNote(Notes.As5, 189.4924415f, 0.10569841666665525f),
          new PlayNote(Notes.C6, 189.7130295f, 0.3262864166666759f),
          new PlayNote(Notes.G5, 190.1542055f, 0.10569841666668367f),
          new PlayNote(Notes.As5, 190.3747935f, 0.3262864166666759f),
          new PlayNote(Notes.As5, 190.8159695f, 0.21599241666666558f),
          new PlayNote(Notes.G5, 191.03655750000001f, 0.10569841666665525f),
          new PlayNote(Notes.As5, 191.2571455f, 0.10569841666665525f),
          new PlayNote(Notes.C6, 191.4777335f, 0.3262864166666759f),
          new PlayNote(Notes.G5, 191.9189095f, 0.10569841666665525f),
          new PlayNote(Notes.Gs5, 192.1394975f, 0.3262864166666759f),
          new PlayNote(Notes.As5, 192.5806735f, 0.3262864166666759f),
          new PlayNote(Notes.Gs5, 193.0218495f, 0.21599241666666558f),
          new PlayNote(Notes.G5, 193.2424375f, 0.10569841666668367f),
          new PlayNote(Notes.F5, 193.46302550000001f, 0.10569841666665525f),
          new PlayNote(Notes.As4, 193.6836135f, 1.5395204166666758f),
          new PlayNote(Notes.As5, 195.6689055f, 0.3262864166666759f),
          new PlayNote(Notes.As5, 196.1100815f, 0.21599241666666558f),
          new PlayNote(Notes.G5, 196.3306695f, 0.10569841666668367f),
          new PlayNote(Notes.As5, 196.55125750000002f, 0.10569841666665525f),
          new PlayNote(Notes.C6, 196.7718455f, 0.3262864166666475f),
          new PlayNote(Notes.G5, 197.2130215f, 0.10569841666668367f),
          new PlayNote(Notes.As5, 197.4336095f, 0.3262864166666759f),
          new PlayNote(Notes.As5, 197.8747855f, 0.21599241666666558f),
          new PlayNote(Notes.G5, 198.0953735f, 0.10569841666668367f),
          new PlayNote(Notes.As5, 198.31596150000001f, 0.10569841666665525f),
          new PlayNote(Notes.C6, 198.5365495f, 0.3262864166666759f),
          new PlayNote(Notes.G5, 198.97772550000002f, 0.10569841666665525f),
          new PlayNote(Notes.Gs5, 199.1983135f, 0.3262864166666475f),
          new PlayNote(Notes.As5, 199.6394895f, 0.3262864166666759f),
          new PlayNote(Notes.Gs5, 200.0806655f, 0.21599241666666558f),
          new PlayNote(Notes.G5, 200.3012535f, 0.10569841666668367f),
          new PlayNote(Notes.F5, 200.5218415f, 0.10569841666668367f),
          new PlayNote(Notes.C5, 200.74242950000001f, 1.5395204166666758f),

        },
        0.5f
        );
    }
}
