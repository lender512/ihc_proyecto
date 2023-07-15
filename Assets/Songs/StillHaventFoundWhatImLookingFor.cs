
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StillHaventFoundWhatImLookingFor : SongScript
{
    public override Song GetSong()
    {
        return new Song(
        3,
        36,
        new List<PlayNote> 
        {
          new PlayNote(Notes.F5, 10.876220052083333f, 0.006127447916668416f),
          new PlayNote(Notes.F5, 10.882347500000002f, 0.3737743229166668f),
          new PlayNote(Notes.Gs5, 11.311268854166668f, 0.3247547395833337f),
          new PlayNote(Notes.Gs5, 11.740190208333335f, 0.3676468749999984f),
          new PlayNote(Notes.F5, 12.218131145833334f, 0.3615194270833335f),
          new PlayNote(Notes.As5, 13.229160052083333f, 0.4289213541666683f),
          new PlayNote(Notes.Gs5, 13.688718645833335f, 0.3615194270833335f),
          new PlayNote(Notes.Gs5, 14.129894895833335f, 0.4105390104166666f),
          new PlayNote(Notes.F5, 14.577198593750001f, 0.3431370833333336f),
          new PlayNote(Notes.F5, 15.618864739583334f, 0.33700963541666873f),
          new PlayNote(Notes.Gs5, 16.01714885416667f, 0.34926453125000023f),
          new PlayNote(Notes.Gs5, 16.446070208333335f, 0.46568604166666816f),
          new PlayNote(Notes.F5, 16.93626604166667f, 0.37377432291666324f),
          new PlayNote(Notes.As5, 17.941167500000002f, 0.3676468749999984f),
          new PlayNote(Notes.Gs5, 18.376216302083336f, 0.4227939062499999f),
          new PlayNote(Notes.F5, 18.829647447916667f, 0.3799017708333352f),
          new PlayNote(Notes.F5, 19.96935276041667f, 0.44730369791666647f),
          new PlayNote(Notes.Ds5, 20.416656458333335f, 0.4105390104166666f),
          new PlayNote(Notes.Cs5, 20.827195468750002f, 0.2941174999999987f),
          new PlayNote(Notes.Ds5, 21.20096979166667f, 0.7781858854166686f),
          new PlayNote(Notes.Cs5, 22.00979291666667f, 0.23897046874999717f),
          new PlayNote(Notes.Cs5, 22.389694687500004f, 1.060048489583334f),
          new PlayNote(Notes.F5, 24.681360208333338f, 0.45955859374999974f),
          new PlayNote(Notes.Ds5, 25.116409010416668f, 0.37377432291667034f),
          new PlayNote(Notes.Cs5, 25.496310781250003f, 0.33088218749999854f),
          new PlayNote(Notes.Ds5, 25.876212552083338f, 0.7598035416666633f),
          new PlayNote(Notes.Cs5, 26.727927812500003f, 0.2634802604166673f),
          new PlayNote(Notes.Cs5, 27.120084479166668f, 0.8272054687500017f),
          new PlayNote(Notes.F5, 29.687485156250002f, 0.3799017708333352f),
          new PlayNote(Notes.Gs5, 30.128661406250004f, 0.34926453125000023f),
          new PlayNote(Notes.Gs5, 30.56983765625f, 0.3676468750000019f),
          new PlayNote(Notes.F5, 31.017141354166668f, 0.5147056250000013f),
          new PlayNote(Notes.As5, 32.0588075f, 0.3676468750000055f),
          new PlayNote(Notes.Gs5, 32.518366093750004f, 0.36151942708333706f),
          new PlayNote(Notes.F5, 32.97179723958334f, 0.5698526562499993f),
          new PlayNote(Notes.F5, 34.43625729166667f, 0.3737743229166668f),
          new PlayNote(Notes.Gs5, 34.85905119791667f, 0.330882187499995f),
          new PlayNote(Notes.Gs5, 35.28184510416667f, 0.43504880208333674f),
          new PlayNote(Notes.F5, 35.747531145833335f, 0.3737743229166668f),
          new PlayNote(Notes.As5, 36.77081494791667f, 0.44117624999999805f),
          new PlayNote(Notes.Gs5, 37.23650098958334f, 0.1715685416666659f),
          new PlayNote(Notes.F5, 37.43870677083334f, 0.2083332291666622f),
          new PlayNote(Notes.Ds5, 37.66542234375f, 0.35539197916666865f),
          new PlayNote(Notes.Cs5, 38.069833906250004f, 0.6004898958333342f),
          new PlayNote(Notes.As5, 39.117627500000005f, 0.533087968750003f),
          new PlayNote(Notes.Gs5, 39.62007822916667f, 0.18995088541666405f),
          new PlayNote(Notes.F5, 39.82228401041667f, 0.17769598958333432f),
          new PlayNote(Notes.Ds5, 40.079636822916676f, 0.5024507291666609f),
          new PlayNote(Notes.Cs5, 40.600469895833335f, 1.1703425520833406f),
          new PlayNote(Notes.F5, 43.51100765625f, 0.3676468750000055f),
          new PlayNote(Notes.Ds5, 43.952183906250006f, 0.3370096354166705f),
          new PlayNote(Notes.Cs5, 44.307575885416675f, 0.3737743229166597f),
          new PlayNote(Notes.Ds5, 44.71198744791668f, 0.8088231249999964f),
          new PlayNote(Notes.Cs5, 45.508555677083336f, 0.3002449479166671f),
          new PlayNote(Notes.Cs5, 45.90071234375001f, 1.0968131770833267f),
          new PlayNote(Notes.Cs5, 48.529387500000006f, 0.2083332291666693f),
          new PlayNote(Notes.Cs5, 48.82963244791667f, 0.23284302083333586f),
          new PlayNote(Notes.Gs5, 49.1176225f, 1.3112738541666715f),
          new PlayNote(Notes.Fs5, 50.876200052083334f, 0.27573515625000056f),
          new PlayNote(Notes.F5, 51.17031755208333f, 0.2512253645833411f),
          new PlayNote(Notes.Cs5, 51.46443505208334f, 1.0600484895833375f),
          new PlayNote(Notes.As4, 53.22914005208334f, 0.18995088541667116f),
          new PlayNote(Notes.As4, 53.529385000000005f, 0.171568541666673f),
          new PlayNote(Notes.As4, 53.811247604166674f, 0.28186260416666187f),
          new PlayNote(Notes.Cs5, 54.12374744791668f, 0.22058812499999902f),
          new PlayNote(Notes.Cs5, 54.41173750000001f, 1.3480385416666678f),
          new PlayNote(Notes.Cs5, 57.94114750000001f, 0.19607833333333247f),
          new PlayNote(Notes.Cs5, 58.22913755208334f, 0.23897046874999717f),
          new PlayNote(Notes.Gs5, 58.498745260416676f, 1.2438719270833332f),
          new PlayNote(Notes.Fs5, 60.287960052083335f, 0.2512253645833411f),
          new PlayNote(Notes.F5, 60.582077552083334f, 0.23897046875000427f),
          new PlayNote(Notes.Cs5, 60.88232250000001f, 1.0477935937500007f),
          new PlayNote(Notes.As4, 62.64090005208334f, 0.17769598958333432f),
          new PlayNote(Notes.As4, 62.93501755208334f, 0.19607833333333957f),
          new PlayNote(Notes.As4, 63.229135052083336f, 0.23284302083334296f),
          new PlayNote(Notes.Cs5, 63.54163489583334f, 0.17769598958333432f),
          new PlayNote(Notes.Cs5, 63.84187984375001f, 1.25612682291667f),
          new PlayNote(Notes.F5, 67.37128984375f, 0.34926453125000023f),
          new PlayNote(Notes.Gs5, 67.78795630208334f, 0.32475473958332657f),
          new PlayNote(Notes.Gs5, 68.21075020833334f, 0.34926453125000023f),
          new PlayNote(Notes.F5, 68.62128921875001f, 0.34926453125000023f),
          new PlayNote(Notes.As5, 69.69972005208334f, 0.39828411458334756f),
          new PlayNote(Notes.Gs5, 70.15315119791667f, 0.3247547395833408f),
          new PlayNote(Notes.Gs5, 70.57594510416668f, 0.5147056250000048f),
          new PlayNote(Notes.F5, 71.02937625000001f, 0.2512253645833198f),
          new PlayNote(Notes.F5, 72.05878750000001f, 0.3431370833333318f),
          new PlayNote(Notes.Gs5, 72.46932651041668f, 0.31249984375000395f),
          new PlayNote(Notes.Gs5, 72.87986552083333f, 0.34926453125000023f),
          new PlayNote(Notes.F5, 73.30878687500001f, 0.34926453125000023f),
          new PlayNote(Notes.Ds5, 73.74383567708334f, 0.14093130208333093f),
          new PlayNote(Notes.Cs5, 73.87251208333333f, 0.1593136458333504f),
          new PlayNote(Notes.As5, 74.46074708333335f, 0.3370096354166634f),
          new PlayNote(Notes.Gs5, 74.85903119791668f, 0.3431370833333318f),
          new PlayNote(Notes.F5, 75.28795255208334f, 0.31249984375000395f),
          new PlayNote(Notes.Cs5, 76.18255994791667f, 0.15931364583333618f),
          new PlayNote(Notes.As5, 76.48280489583335f, 0.7904407812499983f),
          new PlayNote(Notes.Gs5, 77.32226526041667f, 0.5882349999999974f),
          new PlayNote(Notes.Ds5, 77.95951984375f, 0.5147056250000048f),
          new PlayNote(Notes.Cs5, 78.52937250000001f, 1.2377444791666647f),
          new PlayNote(Notes.Cs5, 80.87618505208334f, 0.1654410937500046f),
          new PlayNote(Notes.As5, 81.2131946875f, 0.31249984375000395f),
          new PlayNote(Notes.Gs5, 81.60535135416667f, 0.251225364583334f),
          new PlayNote(Notes.Gs5, 81.9484884375f, 0.22058812500000613f),
          new PlayNote(Notes.F5, 82.16907656250001f, 0.2083332291666551f),
          new PlayNote(Notes.Gs5, 82.42642937500001f, 0.8088231250000035f),
          new PlayNote(Notes.F5, 83.23525250000002f, 1.2071072395833369f),
          new PlayNote(Notes.F5, 86.1764275f, 0.34926453125000023f),
          new PlayNote(Notes.Gs5, 86.59309395833334f, 0.31862729166667236f),
          new PlayNote(Notes.Gs5, 87.04652510416668f, 0.30637239583333553f),
          new PlayNote(Notes.F5, 87.36515239583335f, 0.502450729166668f),
          new PlayNote(Notes.Ds5, 87.89211291666668f, 0.15318619791666777f),
          new PlayNote(Notes.Cs5, 88.01466187500002f, 0.1715685416666588f),
          new PlayNote(Notes.As5, 88.52324005208335f, 0.5821075520833148f),
          new PlayNote(Notes.Gs5, 89.10534760416667f, 0.1286764062500083f),
          new PlayNote(Notes.F5, 89.25240635416667f, 0.1286764062500083f),
          new PlayNote(Notes.Gs5, 89.39333765625001f, 0.23897046874999717f),
          new PlayNote(Notes.F5, 89.70583750000002f, 0.2083332291666551f),
          new PlayNote(Notes.E5, 89.91417072916667f, 0.23284302083334296f),
          new PlayNote(Notes.Cs5, 90.30632739583335f, 0.1715685416666588f),
          new PlayNote(Notes.F5, 90.87618005208334f, 0.4289213541666612f),
          new PlayNote(Notes.Gs5, 91.32348375000001f, 0.31862729166665815f),
          new PlayNote(Notes.Gs5, 91.75240510416667f, 0.3860292187499965f),
          new PlayNote(Notes.F5, 92.12005197916667f, 0.42892135416667543f),
          new PlayNote(Notes.Cs5, 92.64088505208335f, 0.23897046874999717f),
          new PlayNote(Notes.As5, 93.23524750000001f, 0.39828411458333335f),
          new PlayNote(Notes.Gs5, 93.749953125f, 0.1593136458333504f),
          new PlayNote(Notes.F5, 93.94603145833335f, 0.11029406250000306f),
          new PlayNote(Notes.Gs5, 94.10534510416667f, 0.2818626041666761f),
          new PlayNote(Notes.F5, 94.43009984375001f, 0.3002449479166529f),
          new PlayNote(Notes.Cs5, 94.98769760416667f, 0.10416661458333465f),
          new PlayNote(Notes.Cs5, 95.14701125f, 0.1225489583333399f),
          new PlayNote(Notes.As5, 95.30632489583336f, 0.8823524999999961f),
          new PlayNote(Notes.Gs5, 96.18254994791667f, 0.3002449479166813f),
          new PlayNote(Notes.F5, 96.48279489583335f, 0.2941174999999987f),
          new PlayNote(Notes.Ds5, 96.838186875f, 0.5698526562500064f),
          new PlayNote(Notes.Cs5, 97.42642187500002f, 1.1764699999999948f),
          new PlayNote(Notes.Cs5, 99.61392078125002f, 0.11029406249998885f),
          new PlayNote(Notes.Cs5, 99.779361875f, 0.18382343750000985f),
          new PlayNote(Notes.As5, 100.03058723958335f, 0.66176437499999f),
          new PlayNote(Notes.Gs5, 100.74137119791668f, 0.2573528124999882f),
          new PlayNote(Notes.F5, 101.02323380208335f, 0.3063723958333213f),
          new PlayNote(Notes.Ds5, 101.34186109375001f, 0.39215666666666493f),
          new PlayNote(Notes.Cs5, 101.73401776041668f, 0.6372545833333305f),
          new PlayNote(Notes.Ds5, 103.81122260416667f, 0.31249984375000395f),
          new PlayNote(Notes.Cs5, 104.12372244791668f, 0.34926453125000023f),
          new PlayNote(Notes.Cs5, 104.99382005208335f, 0.2083332291666551f),
          new PlayNote(Notes.Cs5, 105.29406500000002f, 0.23897046874999717f),
          new PlayNote(Notes.Gs5, 105.59430994791667f, 1.2499993750000016f),
          new PlayNote(Notes.Fs5, 107.31612281250001f, 0.31862729166665815f),
          new PlayNote(Notes.F5, 107.63475010416667f, 0.2573528125000024f),
          new PlayNote(Notes.Cs5, 107.95337739583336f, 0.9926465624999992f),
          new PlayNote(Notes.As4, 109.70582750000001f, 0.2083332291666551f),
          new PlayNote(Notes.As4, 110.01219989583335f, 0.1715685416666588f),
          new PlayNote(Notes.As4, 110.28793505208336f, 0.24509791666665137f),
          new PlayNote(Notes.Cs5, 110.58818000000001f, 0.17769598958334143f),
          new PlayNote(Notes.Cs5, 110.86391515625002f, 1.4215679166666604f),
          new PlayNote(Notes.Cs5, 114.40558005208335f, 0.14093130208331672f),
          new PlayNote(Notes.Cs5, 114.69357010416667f, 0.17156854166668722f),
          new PlayNote(Notes.Gs5, 114.97543270833336f, 1.0906857291666512f),
          new PlayNote(Notes.Fs5, 116.71562791666668f, 0.2818626041666761f),
          new PlayNote(Notes.F5, 117.03425520833335f, 0.2512253645833198f),
          new PlayNote(Notes.Cs5, 117.33450015625002f, 0.9681367708333397f),
          new PlayNote(Notes.As4, 119.12371494791667f, 0.18995088541667826f),
          new PlayNote(Notes.As4, 119.41783244791668f, 0.1654410937499904f),
          new PlayNote(Notes.As4, 119.68744015625002f, 0.27573515624999345f),
          new PlayNote(Notes.Cs5, 120.00606744791668f, 0.17769598958334143f),
          new PlayNote(Notes.Cs5, 120.30631239583334f, 1.2071072395833227f),
          new PlayNote(Notes.F5, 142.62860515625002f, 0.428921354166647f),
          new PlayNote(Notes.Gs5, 143.05752651041666f, 0.3308821875000092f),
          new PlayNote(Notes.Gs5, 143.48032041666667f, 0.31862729166667236f),
          new PlayNote(Notes.F5, 143.87860453125f, 0.5637252083333522f),
          new PlayNote(Notes.Ds5, 144.43007484375002f, 0.1715685416666588f),
          new PlayNote(Notes.Cs5, 144.60164338541668f, 0.19607833333333247f),
          new PlayNote(Notes.As5, 144.9999275f, 0.47181348958335434f),
          new PlayNote(Notes.Gs5, 145.50850567708335f, 0.2941174999999987f),
          new PlayNote(Notes.Gs5, 145.87002510416667f, 0.39215666666669335f),
          new PlayNote(Notes.F5, 146.29281901041668f, 0.4105390104166702f),
          new PlayNote(Notes.F5, 147.29772046875001f, 0.21446067708333771f),
          new PlayNote(Notes.F5, 147.59183796875f, 0.3002449479166671f),
          new PlayNote(Notes.Gs5, 147.87982802083334f, 0.2512253645833198f),
          new PlayNote(Notes.Gs5, 148.2229651041667f, 0.3860292187499965f),
          new PlayNote(Notes.F5, 148.65801390625f, 0.502450729166668f),
          new PlayNote(Notes.Ds5, 149.17271953125f, 0.2083332291666693f),
          new PlayNote(Notes.As5, 149.69968005208335f, 0.47794093749999433f),
          new PlayNote(Notes.Gs5, 150.15923864583337f, 0.23897046874998296f),
          new PlayNote(Notes.F5, 150.39208166666668f, 0.2757351562500219f),
          new PlayNote(Notes.Ds5, 150.64330703125f, 0.2941174999999987f),
          new PlayNote(Notes.Cs5, 150.9619343229167f, 0.349264531249986f),
          new PlayNote(Notes.As5, 151.47663994791668f, 1.053921041666655f),
          new PlayNote(Notes.Gs5, 152.54894333333334f, 0.26348026041668504f),
          new PlayNote(Notes.F5, 152.8308059375f, 0.39828411458333335f),
          new PlayNote(Notes.Ds5, 153.19845281250002f, 0.5147056250000048f),
          new PlayNote(Notes.Cs5, 153.7009035416667f, 0.8700976041666593f),
          new PlayNote(Notes.Cs5, 156.2376669791667f, 0.14705874999998514f),
          new PlayNote(Notes.As5, 156.46438255208335f, 0.31862729166667236f),
          new PlayNote(Notes.Gs5, 156.87492156250002f, 0.31862729166667236f),
          new PlayNote(Notes.Gs5, 157.2854605729167f, 0.1715685416666588f),
          new PlayNote(Notes.F5, 157.47541145833333f, 0.25122536458337663f),
          new PlayNote(Notes.Gs5, 157.7266368229167f, 0.8088231250000035f),
          new PlayNote(Notes.F5, 158.5354599479167f, 0.8210780208333119f),
          new PlayNote(Notes.F5, 161.17026255208333f, 0.23284302083337138f),
          new PlayNote(Notes.Gs5, 161.45212515625002f, 0.22058812500000613f),
          new PlayNote(Notes.F5, 161.74011520833335f, 0.2573528124999882f),
          new PlayNote(Notes.Gs5, 162.0281052604167f, 0.3063723958333071f),
          new PlayNote(Notes.Ds5, 162.37124234375003f, 0.1286764062499799f),
          new PlayNote(Notes.F5, 162.51217364583334f, 0.349264531249986f),
          new PlayNote(Notes.Ds5, 162.92884010416668f, 0.34926453125001444f),
          new PlayNote(Notes.Cs5, 163.2597222916667f, 0.23284302083331454f),
          new PlayNote(Notes.As5, 163.84182984375002f, 0.349264531249986f),
          new PlayNote(Notes.Gs5, 164.25849630208333f, 0.4105390104166986f),
          new PlayNote(Notes.F5, 164.66290786458333f, 0.2450979166666798f),
          new PlayNote(Notes.E5, 164.90800578125f, 0.1225489583333399f),
          new PlayNote(Notes.Ds5, 165.23888796875002f, 0.31249984375000395f),
          new PlayNote(Notes.Cs5, 165.56977015625003f, 0.2205881249999777f),
          new PlayNote(Notes.F5, 166.13962281250002f, 0.18382343749999563f),
          new PlayNote(Notes.Gs5, 166.42148541666668f, 0.28186260416666187f),
          new PlayNote(Notes.F5, 166.70947546875001f, 0.20220578125000088f),
          new PlayNote(Notes.Gs5, 166.86878911458334f, 0.42892135416667543f),
          new PlayNote(Notes.Ds5, 167.2303085416667f, 0.14705875000001356f),
          new PlayNote(Notes.F5, 167.35285750000003f, 0.36764687499999127f),
          new PlayNote(Notes.As5, 168.52932750000002f, 0.5147056250000048f),
          new PlayNote(Notes.Gs5, 169.11143505208335f, 0.5882349999999974f),
          new PlayNote(Notes.F5, 169.69967005208335f, 0.66176437499999f),
          new PlayNote(Notes.As5, 170.7413361979167f, 0.6004898958333342f),
          new PlayNote(Notes.Gs5, 171.45212015625003f, 0.5147056249999764f),
          new PlayNote(Notes.Ds5, 172.05261005208334f, 0.44117625000001226f),
          new PlayNote(Notes.Cs5, 172.64084505208334f, 1.237744479166679f),
          new PlayNote(Notes.Cs5, 175.03054973958334f, 0.18995088541669247f),
          new PlayNote(Notes.As5, 175.2633927604167f, 0.349264531249986f),
          new PlayNote(Notes.Gs5, 175.68618666666669f, 0.31862729166664394f),
          new PlayNote(Notes.F5, 176.0660884375f, 0.3860292187499965f),
          new PlayNote(Notes.Gs5, 176.47050000000002f, 0.8210780208333119f),
          new PlayNote(Notes.Ds5, 177.3038329166667f, 0.36764687499999127f),
          new PlayNote(Notes.Ds5, 177.67147979166668f, 0.8088231250000035f),
          new PlayNote(Notes.Cs5, 180.2817726041667f, 0.20833322916664088f),
          new PlayNote(Notes.Cs5, 180.5942724479167f, 0.26960770833332504f),
          new PlayNote(Notes.Gs5, 180.90064484375003f, 1.2683817187499926f),
          new PlayNote(Notes.Fs5, 182.6102028125f, 0.3186272916667008f),
          new PlayNote(Notes.F5, 182.9288301041667f, 0.28186260416663345f),
          new PlayNote(Notes.Cs5, 183.2229476041667f, 1.0661759374999917f),
          new PlayNote(Notes.As4, 184.9692702604167f, 0.24509791666665137f),
          new PlayNote(Notes.As4, 185.29402500000003f, 0.2083332291666693f),
          new PlayNote(Notes.As4, 185.58201505208334f, 0.31862729166667236f),
          new PlayNote(Notes.Cs5, 185.91289723958334f, 0.1960783333333609f),
          new PlayNote(Notes.Cs5, 186.23152453125002f, 1.4215679166666746f),
          new PlayNote(Notes.Cs5, 189.68127770833334f, 0.2083332291666693f),
          new PlayNote(Notes.Cs5, 189.98152265625f, 0.2818626041666903f),
          new PlayNote(Notes.Gs5, 190.2940225f, 1.115195520833339f),
          new PlayNote(Notes.Fs5, 192.04034515625003f, 0.2941174999999987f),
          new PlayNote(Notes.F5, 192.3405901041667f, 0.28186260416666187f),
          new PlayNote(Notes.Cs5, 192.64083505208333f, 1.237744479166679f),
          new PlayNote(Notes.As4, 194.39941260416668f, 0.24509791666665137f),
          new PlayNote(Notes.As4, 194.7119124479167f, 0.20833322916664088f),
          new PlayNote(Notes.As4, 194.99377505208335f, 0.31862729166667236f),
          new PlayNote(Notes.Cs5, 195.31240234375002f, 0.20220578125000088f),
          new PlayNote(Notes.Cs5, 195.5942649479167f, 1.550244322916626f),
          new PlayNote(Notes.F5, 199.11754750000003f, 0.4166664583333102f),
          new PlayNote(Notes.Gs5, 199.55259630208334f, 0.343137083333346f),
          new PlayNote(Notes.Gs5, 199.96313531250001f, 0.40441156250000176f),
          new PlayNote(Notes.F5, 200.41656645833334f, 0.39828411458336177f),
          new PlayNote(Notes.As5, 201.46436005208335f, 0.42892135416667543f),
          new PlayNote(Notes.Gs5, 201.9361735416667f, 0.3308821875000092f),
          new PlayNote(Notes.Gs5, 202.3222027604167f, 0.45343114583332067f),
          new PlayNote(Notes.F5, 202.78788880208333f, 0.35539197916668286f),
          new PlayNote(Notes.F5, 203.81730005208334f, 0.416666458333367f),
          new PlayNote(Notes.Gs5, 204.24622140625002f, 0.36151942708332285f),
          new PlayNote(Notes.Gs5, 204.68739765625003f, 0.4166664583333102f),
          new PlayNote(Notes.F5, 205.1347013541667f, 0.36151942708332285f),
          new PlayNote(Notes.As5, 206.19474984375003f, 0.36151942708332285f),
          new PlayNote(Notes.Gs5, 206.63592609375002f, 0.39215666666669335f),
          new PlayNote(Notes.F5, 207.0648474479167f, 0.39215666666666493f),
          new PlayNote(Notes.F5, 208.2045527604167f, 0.36151942708332285f),
          new PlayNote(Notes.Ds5, 208.63347411458335f, 0.31249984375000395f),
          new PlayNote(Notes.Cs5, 208.9949935416667f, 0.349264531249986f),
          new PlayNote(Notes.Ds5, 209.42391489583335f, 0.8517152604166824f),
          new PlayNote(Notes.Cs5, 210.28788505208334f, 0.22671557291667455f),
          new PlayNote(Notes.Cs5, 210.60651234375f, 1.035538697916678f),
          new PlayNote(Notes.F5, 212.89817786458335f, 0.36764687499999127f),
          new PlayNote(Notes.Ds5, 213.30871687500002f, 0.3737743229166881f),
          new PlayNote(Notes.Cs5, 213.70700098958335f, 0.3799017708333565f),
          new PlayNote(Notes.Ds5, 214.13592234375002f, 0.8517152604166824f),
          new PlayNote(Notes.Cs5, 214.99376505208335f, 0.2512253645833482f),
          new PlayNote(Notes.Cs5, 215.3001374479167f, 0.9620093229166287f),
          new PlayNote(Notes.F5, 217.9778321875f, 0.3860292187499965f),
          new PlayNote(Notes.Gs5, 218.4067535416667f, 0.3308821875000092f),
          new PlayNote(Notes.Gs5, 218.81729255208336f, 0.4166664583333386f),
          new PlayNote(Notes.F5, 219.28297859375002f, 0.3799017708333281f),
          new PlayNote(Notes.As5, 220.29400750000002f, 0.3799017708333281f),
          new PlayNote(Notes.Gs5, 220.73518375000003f, 0.42892135416667543f),
          new PlayNote(Notes.F5, 221.21312468750003f, 0.5698526562499922f),
          new PlayNote(Notes.F5, 222.6469475f, 0.42892135416670385f),
          new PlayNote(Notes.Gs5, 223.0942511979167f, 0.31862729166664394f),
          new PlayNote(Notes.Gs5, 223.50479020833333f, 0.422793906250007f),
          new PlayNote(Notes.F5, 223.94596645833334f, 0.34926453125001444f),
          new PlayNote(Notes.As5, 224.9876326041667f, 0.3737743229166597f),
          new PlayNote(Notes.Gs5, 225.44106375f, 0.20220578125000088f),
          new PlayNote(Notes.F5, 225.6493969791667f, 0.2512253645833198f),
          new PlayNote(Notes.Ds5, 225.90062234375003f, 0.36764687499999127f),
          new PlayNote(Notes.Cs5, 226.26214177083335f, 0.5698526562499922f),
          new PlayNote(Notes.As5, 227.35895494791671f, 0.5514703124999869f),
          new PlayNote(Notes.Gs5, 227.89817036458334f, 0.2450979166666798f),
          new PlayNote(Notes.F5, 228.14326828125002f, 0.3370096354166776f),
          new PlayNote(Notes.Ds5, 228.44964067708335f, 0.6495094791666816f),
          new PlayNote(Notes.Cs5, 229.09915015625003f, 1.1519602083333211f),
          new PlayNote(Notes.F5, 231.77684489583334f, 0.3799017708333565f),
          new PlayNote(Notes.Ds5, 232.1935113541667f, 0.2941174999999987f),
          new PlayNote(Notes.Cs5, 232.5243935416667f, 0.3799017708332997f),
          new PlayNote(Notes.Ds5, 233.0023344791667f, 0.7536760937499878f),
          new PlayNote(Notes.Cs5, 233.7927752604167f, 0.24509791666665137f),
          new PlayNote(Notes.Cs5, 234.15429468750003f, 1.3235287500000084f),
          new PlayNote(Notes.Cs5, 236.7890972916667f, 0.18995088541663563f),
          new PlayNote(Notes.Cs5, 237.05870500000003f, 0.23897046874998296f),
          new PlayNote(Notes.Gs5, 237.36507739583334f, 1.1029406250000022f),
          new PlayNote(Notes.Fs5, 239.0868902604167f, 0.26960770833332504f),
          new PlayNote(Notes.F5, 239.3993901041667f, 0.26960770833332504f),
          new PlayNote(Notes.Cs5, 239.71801739583336f, 0.9191171874999782f),
          new PlayNote(Notes.As4, 241.44595770833334f, 0.21446067708336614f),
          new PlayNote(Notes.As4, 241.74007520833334f, 0.18995088541669247f),
          new PlayNote(Notes.As4, 242.0280652604167f, 0.28186260416666187f),
          new PlayNote(Notes.Cs5, 242.3589474479167f, 0.17156854166663038f),
          new PlayNote(Notes.Cs5, 242.64081005208334f, 1.4767149479166903f),
          new PlayNote(Notes.Cs5, 246.15796515625001f, 0.15931364583332197f),
          new PlayNote(Notes.Cs5, 246.44595520833334f, 0.20220578125000088f),
          new PlayNote(Notes.Gs5, 246.74620015625004f, 1.0906857291666654f),
          new PlayNote(Notes.Fs5, 248.52928750000004f, 0.2573528124999882f),
          new PlayNote(Notes.F5, 248.8295324479167f, 0.26960770833332504f),
          new PlayNote(Notes.Cs5, 249.12977739583334f, 0.925244635416675f),
          new PlayNote(Notes.As4, 250.85771770833335f, 0.17156854166668722f),
          new PlayNote(Notes.As4, 251.15796265625002f, 0.17156854166668722f),
          new PlayNote(Notes.As4, 251.45820760416672f, 0.20220578125000088f),
          new PlayNote(Notes.Cs5, 251.74619765625002f, 0.20220578125000088f),
          new PlayNote(Notes.Cs5, 252.07707984375003f, 1.3235287500000084f),
          new PlayNote(Notes.Ds5, 255.56972515625003f, 0.18995088541666405f),
          new PlayNote(Notes.Ds5, 255.85771520833336f, 0.20220578125000088f),
          new PlayNote(Notes.Ds5, 256.17021505208334f, 1.2071072395833653f),
          new PlayNote(Notes.F5, 257.9287926041667f, 0.22671557291664612f),
          new PlayNote(Notes.Ds5, 258.22903755208335f, 0.2083332291666693f),
          new PlayNote(Notes.Cs5, 258.5170276041667f, 1.0600484895833233f),
          new PlayNote(Notes.As4, 260.2878600520834f, 0.18995088541663563f),
          new PlayNote(Notes.As4, 260.5758501041667f, 0.18995088541663563f),
          new PlayNote(Notes.As4, 260.8760950520834f, 0.28186260416663345f),
          new PlayNote(Notes.Gs4, 261.1885948958334f, 0.18995088541663563f),
          new PlayNote(Notes.Gs4, 261.4949672916667f, 1.6360285937500407f),
          new PlayNote(Notes.Cs5, 264.9876126041667f, 0.18995088541663563f),
          new PlayNote(Notes.Cs5, 265.27560265625004f, 0.2450979166666798f),
          new PlayNote(Notes.Ds5, 265.5758476041667f, 0.9742642187500223f),
          new PlayNote(Notes.F5, 267.3589349479167f, 0.22671557291664612f),
          new PlayNote(Notes.Ds5, 267.64079755208337f, 0.2144606770833093f),
          new PlayNote(Notes.Cs5, 267.9287876041667f, 0.9191171874999782f),
          new PlayNote(Notes.As4, 269.70574750000003f, 0.18995088541669247f),
          new PlayNote(Notes.As4, 269.99986500000006f, 0.1776959895832988f),
          new PlayNote(Notes.As4, 270.27560015625005f, 0.2941174999999703f),
          new PlayNote(Notes.Gs4, 270.58810000000005f, 0.2083332291666693f),
          new PlayNote(Notes.Gs4, 270.8883449479167f, 1.8382343750000132f),

        },
        0.5f
        );
    }
}
