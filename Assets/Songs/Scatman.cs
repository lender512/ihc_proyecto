
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scatman : SongScript
{
    public override Song GetSong()
    {
        return new Song(
        6,
        28,
        new List<PlayNote> 
        {
          new PlayNote(Notes.F4, 2.20588f, 0.1585476250000002f),
          new PlayNote(Notes.F4, 2.426468f, 0.1401652916666669f),
          new PlayNote(Notes.Gs4, 2.647056f, 0.21829020833333335f),
          new PlayNote(Notes.F4, 3.088232f, 0.39981575000000014f),
          new PlayNote(Notes.F4, 10.147048f, 0.15854762500000064f),
          new PlayNote(Notes.F4, 10.367636000000001f, 0.14016529166666558f),
          new PlayNote(Notes.Gs4, 10.588224f, 0.21829020833333423f),
          new PlayNote(Notes.F4, 11.0294f, 0.3883267916666657f),
          new PlayNote(Notes.F4, 17.113952333333334f, 0.07123154166666623f),
          new PlayNote(Notes.F4, 17.205864000000002f, 0.07123154166666623f),
          new PlayNote(Notes.F4, 17.334540333333333f, 0.08272050000000064f),
          new PlayNote(Notes.F4, 17.426452f, 0.07812491666666688f),
          new PlayNote(Notes.F4, 17.555128333333332f, 0.07812491666666688f),
          new PlayNote(Notes.Gs4, 17.64704f, 0.33317979166666944f),
          new PlayNote(Notes.G4, 18.088216f, 0.09880504166666881f),
          new PlayNote(Notes.Gs4, 18.308804000000002f, 0.08501829166666752f),
          new PlayNote(Notes.G4, 18.529392f, 0.10340062499999902f),
          new PlayNote(Notes.F4, 18.658068333333333f, 0.08272050000000064f),
          new PlayNote(Notes.C4, 18.878656333333332f, 0.1309741250000016f),
          new PlayNote(Notes.G4, 19.85292f, 0.11259179166666655f),
          new PlayNote(Notes.Gs4, 20.073508f, 0.10569841666666946f),
          new PlayNote(Notes.G4, 20.294096f, 0.09880504166666881f),
          new PlayNote(Notes.F4, 20.422772333333334f, 0.11259179166666655f),
          new PlayNote(Notes.C4, 20.643360333333334f, 0.14476087499999934f),
          new PlayNote(Notes.Gs4, 21.176448f, 0.3584555000000016f),
          new PlayNote(Notes.G4, 21.617624f, 0.11718737500000032f),
          new PlayNote(Notes.Gs4, 21.838212000000002f, 0.09880504166666526f),
          new PlayNote(Notes.G4, 22.0588f, 0.09880504166666526f),
          new PlayNote(Notes.Ds4, 22.187476333333333f, 0.10569841666666946f),
          new PlayNote(Notes.As3, 22.408064333333332f, 0.15165425f),
          new PlayNote(Notes.G4, 23.382328f, 0.1194851666666672f),
          new PlayNote(Notes.Gs4, 23.602916f, 0.11029399999999967f),
          new PlayNote(Notes.G4, 23.823504f, 0.11029399999999967f),
          new PlayNote(Notes.F4, 23.952180333333335f, 0.11259179166666655f),
          new PlayNote(Notes.F4, 24.172768333333334f, 0.07123154166666623f),
          new PlayNote(Notes.F4, 24.264680000000002f, 0.07123154166666623f),
          new PlayNote(Notes.F4, 24.393356333333333f, 0.08272050000000064f),
          new PlayNote(Notes.F4, 24.485268f, 0.07812491666666688f),
          new PlayNote(Notes.F4, 24.613944333333333f, 0.07812491666666688f),
          new PlayNote(Notes.Gs4, 24.705856f, 0.33317979166666944f),
          new PlayNote(Notes.G4, 25.147032f, 0.09880504166666881f),
          new PlayNote(Notes.Gs4, 25.367620000000002f, 0.08501829166666752f),
          new PlayNote(Notes.G4, 25.588208f, 0.10340062499999902f),
          new PlayNote(Notes.F4, 25.716884333333333f, 0.08272050000000064f),
          new PlayNote(Notes.C4, 25.937472333333332f, 0.15854762500000064f),
          new PlayNote(Notes.G4, 26.911736f, 0.11259179166666655f),
          new PlayNote(Notes.Gs4, 27.132324f, 0.10569841666666946f),
          new PlayNote(Notes.G4, 27.352912f, 0.09880504166666881f),
          new PlayNote(Notes.F4, 27.481588333333335f, 0.11259179166666655f),
          new PlayNote(Notes.C4, 27.702176333333334f, 0.14476087499999934f),
          new PlayNote(Notes.Gs4, 28.235264f, 0.3584555000000016f),
          new PlayNote(Notes.G4, 28.67644f, 0.11718737500000032f),
          new PlayNote(Notes.Gs4, 28.897028000000002f, 0.09880504166666171f),
          new PlayNote(Notes.G4, 29.117616f, 0.09880504166666526f),
          new PlayNote(Notes.Ds4, 29.246292333333336f, 0.1056984166666659f),
          new PlayNote(Notes.As3, 29.466880333333336f, 0.15165425f),
          new PlayNote(Notes.G4, 30.441144f, 0.11948516666666364f),
          new PlayNote(Notes.Gs4, 30.661732f, 0.11029399999999967f),
          new PlayNote(Notes.G4, 30.88232f, 0.11029399999999967f),
          new PlayNote(Notes.Ds4, 31.010996333333335f, 0.11259179166666655f),
          new PlayNote(Notes.As3, 31.231584333333338f, 0.15165425f),
          new PlayNote(Notes.F4, 75.34918433333333f, 0.07123154166667689f),
          new PlayNote(Notes.F4, 75.441096f, 0.07123154166667689f),
          new PlayNote(Notes.F4, 75.56977233333333f, 0.08272049999999354f),
          new PlayNote(Notes.F4, 75.66168400000001f, 0.07812491666666688f),
          new PlayNote(Notes.F4, 75.79036033333333f, 0.07812491666668109f),
          new PlayNote(Notes.Gs4, 75.882272f, 0.3331797916666659f),
          new PlayNote(Notes.G4, 76.323448f, 0.09880504166667947f),
          new PlayNote(Notes.Gs4, 76.544036f, 0.08501829166667108f),
          new PlayNote(Notes.G4, 76.764624f, 0.10340062500000613f),
          new PlayNote(Notes.F4, 76.89330033333333f, 0.08272050000000775f),
          new PlayNote(Notes.C4, 77.11388833333334f, 0.1309741249999945f),
          new PlayNote(Notes.G4, 78.08815200000001f, 0.11259179166665945f),
          new PlayNote(Notes.Gs4, 78.30874f, 0.10569841666666946f),
          new PlayNote(Notes.G4, 78.529328f, 0.09880504166666526f),
          new PlayNote(Notes.F4, 78.65800433333334f, 0.11259179166665945f),
          new PlayNote(Notes.C4, 78.87859233333333f, 0.1447608750000029f),
          new PlayNote(Notes.Gs4, 79.41168f, 0.35845550000000515f),
          new PlayNote(Notes.G4, 79.852856f, 0.11718737500000032f),
          new PlayNote(Notes.Gs4, 80.07344400000001f, 0.09880504166666526f),
          new PlayNote(Notes.G4, 80.294032f, 0.09880504166666526f),
          new PlayNote(Notes.Ds4, 80.42270833333333f, 0.10569841666666946f),
          new PlayNote(Notes.As3, 80.64329633333332f, 0.1516542500000071f),
          new PlayNote(Notes.G4, 81.61756f, 0.11948516666667786f),
          new PlayNote(Notes.Gs4, 81.838148f, 0.11029399999999612f),
          new PlayNote(Notes.G4, 82.058736f, 0.11029400000001033f),
          new PlayNote(Notes.F4, 82.18741233333333f, 0.11259179166667366f),
          new PlayNote(Notes.F4, 82.40800033333333f, 0.07123154166666268f),
          new PlayNote(Notes.F4, 82.49991200000001f, 0.07123154166666268f),
          new PlayNote(Notes.F4, 82.62858833333333f, 0.08272050000000775f),
          new PlayNote(Notes.F4, 82.7205f, 0.07812491666666688f),
          new PlayNote(Notes.F4, 82.84917633333333f, 0.07812491666666688f),
          new PlayNote(Notes.Gs4, 82.94108800000001f, 0.3331797916666659f),
          new PlayNote(Notes.G4, 83.382264f, 0.09880504166666526f),
          new PlayNote(Notes.Gs4, 83.602852f, 0.08501829166667108f),
          new PlayNote(Notes.G4, 83.82344f, 0.10340062499999192f),
          new PlayNote(Notes.F4, 83.95211633333334f, 0.08272049999999354f),
          new PlayNote(Notes.C4, 84.17270433333333f, 0.15854762499999708f),
          new PlayNote(Notes.G4, 85.146968f, 0.11259179166667366f),
          new PlayNote(Notes.Gs4, 85.36755600000001f, 0.10569841666666946f),
          new PlayNote(Notes.G4, 85.588144f, 0.09880504166667947f),
          new PlayNote(Notes.F4, 85.71682033333333f, 0.11259179166667366f),
          new PlayNote(Notes.C4, 85.93740833333334f, 0.1447608749999887f),
          new PlayNote(Notes.Gs4, 86.470496f, 0.35845550000000515f),
          new PlayNote(Notes.G4, 86.911672f, 0.11718737500000032f),
          new PlayNote(Notes.Gs4, 87.13226f, 0.09880504166666526f),
          new PlayNote(Notes.G4, 87.35284800000001f, 0.09880504166666526f),
          new PlayNote(Notes.Ds4, 87.48152433333333f, 0.10569841666668367f),
          new PlayNote(Notes.As3, 87.70211233333333f, 0.15165424999999289f),
          new PlayNote(Notes.G4, 88.676376f, 0.11948516666666364f),
          new PlayNote(Notes.Gs4, 88.896964f, 0.11029400000001033f),
          new PlayNote(Notes.G4, 89.117552f, 0.11029399999999612f),
          new PlayNote(Notes.Ds4, 89.24622833333333f, 0.11259179166667366f),
          new PlayNote(Notes.As3, 89.46681633333333f, 0.1516542500000071f),
          new PlayNote(Notes.F4, 107.11385633333333f, 0.07123154166667689f),
          new PlayNote(Notes.F4, 107.205768f, 0.07123154166666268f),
          new PlayNote(Notes.F4, 107.33444433333334f, 0.08272049999999354f),
          new PlayNote(Notes.F4, 107.426356f, 0.07812491666668109f),
          new PlayNote(Notes.F4, 107.55503233333333f, 0.07812491666666688f),
          new PlayNote(Notes.Gs4, 107.646944f, 0.3331797916666659f),
          new PlayNote(Notes.G4, 108.08812f, 0.09880504166666526f),
          new PlayNote(Notes.Gs4, 108.30870800000001f, 0.08501829166665686f),
          new PlayNote(Notes.G4, 108.529296f, 0.10340062500000613f),
          new PlayNote(Notes.F4, 108.65797233333333f, 0.08272049999999354f),
          new PlayNote(Notes.C4, 108.87856033333333f, 0.1309741250000087f),
          new PlayNote(Notes.G4, 109.852824f, 0.11259179166667366f),
          new PlayNote(Notes.Gs4, 110.073412f, 0.10569841666666946f),
          new PlayNote(Notes.G4, 110.294f, 0.09880504166667947f),
          new PlayNote(Notes.F4, 110.42267633333333f, 0.11259179166667366f),
          new PlayNote(Notes.C4, 110.64326433333333f, 0.1447608750000029f),
          new PlayNote(Notes.Gs4, 111.17635200000001f, 0.35845549999999093f),
          new PlayNote(Notes.G4, 111.61752800000001f, 0.11718737500000032f),
          new PlayNote(Notes.Gs4, 111.838116f, 0.09880504166667947f),
          new PlayNote(Notes.G4, 112.058704f, 0.09880504166666526f),
          new PlayNote(Notes.Ds4, 112.18738033333334f, 0.10569841666666946f),
          new PlayNote(Notes.As3, 112.40796833333333f, 0.1516542500000071f),
          new PlayNote(Notes.G4, 113.382232f, 0.11948516666666364f),
          new PlayNote(Notes.Gs4, 113.60282000000001f, 0.11029399999999612f),
          new PlayNote(Notes.G4, 113.823408f, 0.11029399999999612f),
          new PlayNote(Notes.F4, 113.95208433333335f, 0.11259179166665945f),
          new PlayNote(Notes.F4, 121.3234f, 0.15854762499999708f),
          new PlayNote(Notes.F4, 121.543988f, 0.14016529166666203f),
          new PlayNote(Notes.As4, 121.764576f, 0.20450345833333472f),
          new PlayNote(Notes.Gs4, 122.19196525000001f, 0.3906245833333344f),
          new PlayNote(Notes.F4, 135.441032f, 0.15854762499998287f),
          new PlayNote(Notes.F4, 135.66162f, 0.14016529166667624f),
          new PlayNote(Notes.Gs4, 135.882208f, 0.21829020833334312f),
          new PlayNote(Notes.F4, 136.323384f, 0.38832679166665685f),
          new PlayNote(Notes.F4, 142.49984800000001f, 0.15854762499998287f),
          new PlayNote(Notes.F4, 142.720436f, 0.14016529166664782f),
          new PlayNote(Notes.As4, 142.941024f, 0.20450345833333472f),
          new PlayNote(Notes.Gs4, 143.36841325f, 0.3906245833333344f),
          new PlayNote(Notes.F4, 149.558664f, 0.1585476250000113f),
          new PlayNote(Notes.F4, 149.779252f, 0.14016529166664782f),
          new PlayNote(Notes.Gs4, 149.99984f, 0.21829020833334312f),
          new PlayNote(Notes.F4, 150.441016f, 0.38832679166668527f),
          new PlayNote(Notes.G4, 152.20572f, 0.11259179166665945f),
          new PlayNote(Notes.Gs4, 152.426308f, 0.10569841666665525f),
          new PlayNote(Notes.G4, 152.646896f, 0.09880504166665105f),
          new PlayNote(Notes.F4, 152.77557233333334f, 0.11259179166665945f),
          new PlayNote(Notes.C4, 152.99616033333334f, 0.1447608750000029f),
          new PlayNote(Notes.Gs4, 153.529248f, 0.35845550000001936f),
          new PlayNote(Notes.G4, 153.970424f, 0.1171873749999861f),
          new PlayNote(Notes.Gs4, 154.191012f, 0.09880504166665105f),
          new PlayNote(Notes.G4, 154.4116f, 0.09880504166667947f),
          new PlayNote(Notes.Ds4, 154.54027633333334f, 0.10569841666665525f),
          new PlayNote(Notes.As3, 154.76086433333336f, 0.15165424999997867f),
          new PlayNote(Notes.G4, 155.735128f, 0.11948516666666364f),
          new PlayNote(Notes.Gs4, 155.955716f, 0.11029400000001033f),
          new PlayNote(Notes.G4, 156.17630400000002f, 0.1102939999999819f),
          new PlayNote(Notes.F4, 156.30498033333333f, 0.11259179166665945f),
          new PlayNote(Notes.F4, 156.61748f, 0.1585476250000113f),
          new PlayNote(Notes.F4, 156.838068f, 0.14016529166667624f),
          new PlayNote(Notes.Gs4, 157.058656f, 0.3331797916666517f),
          new PlayNote(Notes.G4, 157.499832f, 0.09880504166665105f),
          new PlayNote(Notes.Gs4, 157.72042000000002f, 0.08501829166664265f),
          new PlayNote(Notes.G4, 157.941008f, 0.10340062500000613f),
          new PlayNote(Notes.F4, 158.06968433333336f, 0.08272049999999354f),
          new PlayNote(Notes.C4, 158.29027233333335f, 0.1309741249999945f),
          new PlayNote(Notes.G4, 159.264536f, 0.11259179166665945f),
          new PlayNote(Notes.Gs4, 159.485124f, 0.10569841666665525f),
          new PlayNote(Notes.G4, 159.705712f, 0.09880504166665105f),
          new PlayNote(Notes.F4, 159.83438833333335f, 0.11259179166665945f),
          new PlayNote(Notes.C4, 160.05497633333334f, 0.1447608750000029f),
          new PlayNote(Notes.Gs4, 160.588064f, 0.35845549999999093f),
          new PlayNote(Notes.G4, 161.02924000000002f, 0.1171873749999861f),
          new PlayNote(Notes.Gs4, 161.249828f, 0.09880504166665105f),
          new PlayNote(Notes.G4, 161.470416f, 0.09880504166665105f),
          new PlayNote(Notes.Ds4, 161.59909233333335f, 0.10569841666665525f),
          new PlayNote(Notes.As3, 161.81968033333334f, 0.1516542500000071f),
          new PlayNote(Notes.G4, 162.793944f, 0.11948516666666364f),
          new PlayNote(Notes.Gs4, 163.014532f, 0.11029400000001033f),
          new PlayNote(Notes.G4, 163.23512f, 0.11029400000001033f),
          new PlayNote(Notes.F4, 163.36379633333334f, 0.11259179166665945f),
          new PlayNote(Notes.F4, 163.58438433333333f, 0.07123154166666268f),
          new PlayNote(Notes.F4, 163.676296f, 0.07123154166666268f),
          new PlayNote(Notes.F4, 163.80497233333335f, 0.08272049999999354f),
          new PlayNote(Notes.F4, 163.896884f, 0.07812491666666688f),
          new PlayNote(Notes.F4, 164.02556033333335f, 0.07812491666666688f),
          new PlayNote(Notes.Gs4, 164.117472f, 0.3331797916666801f),
          new PlayNote(Notes.G4, 164.558648f, 0.09880504166665105f),
          new PlayNote(Notes.Gs4, 164.779236f, 0.08501829166667108f),
          new PlayNote(Notes.G4, 164.99982400000002f, 0.10340062499997771f),
          new PlayNote(Notes.F4, 165.12850033333333f, 0.08272050000002196f),
          new PlayNote(Notes.C4, 165.34908833333336f, 0.15854762499998287f),
          new PlayNote(Notes.G4, 166.323352f, 0.11259179166665945f),
          new PlayNote(Notes.Gs4, 166.54394f, 0.10569841666668367f),
          new PlayNote(Notes.G4, 166.764528f, 0.09880504166665105f),
          new PlayNote(Notes.F4, 166.89320433333336f, 0.11259179166665945f),
          new PlayNote(Notes.C4, 167.11379233333335f, 0.1447608750000029f),
          new PlayNote(Notes.Gs4, 167.64688f, 0.35845549999999093f),
          new PlayNote(Notes.G4, 168.088056f, 0.11718737500001453f),
          new PlayNote(Notes.Gs4, 168.30864400000002f, 0.09880504166665105f),
          new PlayNote(Notes.G4, 168.529232f, 0.09880504166665105f),
          new PlayNote(Notes.Ds4, 168.65790833333335f, 0.10569841666665525f),
          new PlayNote(Notes.As3, 168.87849633333335f, 0.1516542500000071f),

        }
        );
    }
}