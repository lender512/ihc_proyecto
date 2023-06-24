
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SwanLake : SongScript
{
    public override Song GetSong()
    {
        return new Song(
        3,
        9,
        new List<PlayNote> 
        {
          new PlayNote(Notes.Fs5, 6.0234375f, 1.484375f),
          new PlayNote(Notes.B4, 7.5078125f, 0.4375f),
          new PlayNote(Notes.Cs5, 7.8828125f, 0.4140625f),
          new PlayNote(Notes.D5, 8.234375f, 0.421875f),
          new PlayNote(Notes.E5, 8.59375f, 0.4375f),
          new PlayNote(Notes.Fs5, 8.96875f, 1.15625f),
          new PlayNote(Notes.D5, 10.125f, 0.390625f),
          new PlayNote(Notes.Fs5, 10.515625f, 1.0859375f),
          new PlayNote(Notes.D5, 11.6015625f, 0.4140625f),
          new PlayNote(Notes.Fs5, 12.015625f, 1.09375f),
          new PlayNote(Notes.B4, 13.109375f, 0.3828125f),
          new PlayNote(Notes.D5, 13.4921875f, 0.3828125f),
          new PlayNote(Notes.B4, 13.875f, 0.390625f),
          new PlayNote(Notes.G4, 14.265625f, 0.3984375f),
          new PlayNote(Notes.D5, 14.6640625f, 0.3828125f),
          new PlayNote(Notes.B4, 15.046875f, 1.828125f),
          new PlayNote(Notes.E5, 16.875f, 0.3828125f),
          new PlayNote(Notes.D5, 17.2578125f, 0.359375f),
          new PlayNote(Notes.Cs5, 17.6171875f, 0.40625f),
          new PlayNote(Notes.Fs5, 18.0234375f, 1.4921875f),
          new PlayNote(Notes.B4, 19.515625f, 0.4375f),
          new PlayNote(Notes.Cs5, 19.890625f, 0.40625f),
          new PlayNote(Notes.D5, 20.2578125f, 0.359375f),
          new PlayNote(Notes.E5, 20.6171875f, 0.3828125f),
          new PlayNote(Notes.Fs5, 21.0f, 1.15625f),
          new PlayNote(Notes.D5, 22.15625f, 0.3671875f),
          new PlayNote(Notes.Fs5, 22.5234375f, 1.109375f),
          new PlayNote(Notes.D5, 23.6328125f, 0.3828125f),
          new PlayNote(Notes.Fs5, 24.015625f, 1.1171875f),
          new PlayNote(Notes.B4, 25.1328125f, 0.3828125f),
          new PlayNote(Notes.D5, 25.515625f, 0.3671875f),
          new PlayNote(Notes.B4, 25.8828125f, 0.3671875f),
          new PlayNote(Notes.G4, 26.25f, 0.375f),
          new PlayNote(Notes.D5, 26.625f, 0.3671875f),
          new PlayNote(Notes.B4, 26.9921875f, 2.2109375f),
          new PlayNote(Notes.B4, 29.265625f, 0.734375f),
          new PlayNote(Notes.Cs5, 30.0f, 0.7142799999999987f),
          new PlayNote(Notes.D5, 30.71428f, 0.7142800000000022f),
          new PlayNote(Notes.E5, 31.42856f, 0.7068395833333305f),
          new PlayNote(Notes.Fs5, 32.13539958333333f, 0.3645804166666693f),
          new PlayNote(Notes.G5, 32.49998f, 0.3645804166666693f),
          new PlayNote(Notes.A5, 32.86456041666667f, 1.0416583333333307f),
          new PlayNote(Notes.G5, 33.90621875f, 0.3645804166666693f),
          new PlayNote(Notes.Fs5, 34.27079916666667f, 0.7291608333333315f),
          new PlayNote(Notes.G5, 35.02972166666667f, 0.37946124999999853f),
          new PlayNote(Notes.A5, 35.409182916666666f, 0.3422591666666648f),
          new PlayNote(Notes.B5, 35.75144208333333f, 1.0416583333333378f),
          new PlayNote(Notes.A5, 36.79310041666667f, 0.3645804166666622f),
          new PlayNote(Notes.G5, 37.15768083333333f, 0.6696375000000074f),
          new PlayNote(Notes.A5, 37.84219916666667f, 0.37202083333333036f),
          new PlayNote(Notes.B5, 38.21422f, 0.37202083333333746f),
          new PlayNote(Notes.Cs6, 38.586240833333335f, 1.0639795833333352f),
          new PlayNote(Notes.B5, 39.65022041666667f, 0.3645804166666622f),
          new PlayNote(Notes.Fs5, 40.01480083333333f, 0.3571400000000011f),
          new PlayNote(Notes.D5, 40.37194083333333f, 0.3869016666666667f),
          new PlayNote(Notes.Cs5, 40.7588425f, 0.34969958333333295f),
          new PlayNote(Notes.B4, 41.10854208333333f, 0.3567730208333373f),
          new PlayNote(Notes.Cs5, 41.46531510416667f, 0.6998669791666643f),
          new PlayNote(Notes.D5, 42.165182083333335f, 0.6630318750000015f),
          new PlayNote(Notes.E5, 42.828213958333336f, 0.7219680416666634f),
          new PlayNote(Notes.Fs5, 43.550182f, 0.36098402083333525f),
          new PlayNote(Notes.G5, 43.911166020833335f, 0.39781912499999805f),
          new PlayNote(Notes.A5, 44.30898514583333f, 1.0129318020833367f),
          new PlayNote(Notes.G5, 45.32191694791667f, 0.35390913541666436f),
          new PlayNote(Notes.Fs5, 45.675826083333334f, 0.7078182708333358f),
          new PlayNote(Notes.G5, 46.340308541666666f, 0.38279967708333373f),
          new PlayNote(Notes.A5, 46.72310821875f, 0.3611317708333388f),
          new PlayNote(Notes.B5, 47.08423998958334f, 1.0181617395833271f),
          new PlayNote(Notes.A5, 48.102401729166665f, 0.3540484374999977f),
          new PlayNote(Notes.G5, 48.45645016666666f, 0.616044281249998f),
          new PlayNote(Notes.A5, 49.100818322916666f, 0.33280553124999557f),
          new PlayNote(Notes.B5, 49.43362385416666f, 0.3611294062500008f),
          new PlayNote(Notes.C6, 49.79475326041666f, 0.9617400104166691f),
          new PlayNote(Notes.G5, 50.75649327083333f, 0.3332254999999975f),
          new PlayNote(Notes.E5, 51.08971877083333f, 0.6525666041666653f),
          new PlayNote(Notes.G5, 51.742285374999994f, 0.35405209375000624f),
          new PlayNote(Notes.C6, 52.09633746875f, 0.34016769791666235f),
          new PlayNote(Notes.Cs6, 52.43650516666666f, 1.011346583333335f),
          new PlayNote(Notes.Gs5, 53.44785175f, 0.341233625000001f),
          new PlayNote(Notes.Cs6, 53.789085375f, 0.9578746875000022f),
          new PlayNote(Notes.Fs5, 54.7469600625f, 0.3345353125000088f),
          new PlayNote(Notes.B5, 55.08149537500001f, 2.919178124999995f),
          new PlayNote(Notes.D5, 58.000673500000005f, 2.919178125000002f),
          new PlayNote(Notes.B4, 58.01591725000001f, 2.9039343749999986f),
          new PlayNote(Notes.D5, 60.91985162500001f, 2.1798562500000003f),
          new PlayNote(Notes.E5, 63.09970787500001f, 0.7469437499999998f),
          new PlayNote(Notes.D5, 63.84665162500001f, 1.4710218750000053f),
          new PlayNote(Notes.B4, 63.861895375f, 2.8963125000000076f),
          new PlayNote(Notes.E5, 65.31767350000001f, 1.471021874999991f),
          new PlayNote(Notes.D5, 66.75820787500001f, 1.463399999999993f),
          new PlayNote(Notes.Fs5, 66.788695375f, 1.448156250000011f),
          new PlayNote(Notes.E5, 68.221607875f, 1.5015093749999977f),
          new PlayNote(Notes.G5, 68.23685162500001f, 1.4862656249999873f),
          new PlayNote(Notes.Fs5, 69.72311725f, 4.374956250000011f),
          new PlayNote(Notes.B4, 74.09045162500001f, 0.7393218750000017f),
          new PlayNote(Notes.D5, 74.09807350000001f, 0.7164562499999931f),
          new PlayNote(Notes.E5, 74.81452975f, 0.7393218750000017f),
          new PlayNote(Notes.As4, 74.82977350000002f, 0.7164562499999931f),
          new PlayNote(Notes.B4, 75.54622975000001f, 0.08400999999999215f),
          new PlayNote(Notes.D5, 75.55385162500001f, 0.0902768750000007f),
          new PlayNote(Notes.B4, 75.76912725000001f, 0.07638812499999403f),
          new PlayNote(Notes.D5, 75.776071625f, 0.07638812500000824f),
          new PlayNote(Notes.B4, 75.99134725f, 0.08333249999999737f),
          new PlayNote(Notes.D5, 75.99829162500001f, 0.08333249999999737f),
          new PlayNote(Notes.D5, 76.220511625f, 0.08333250000001158f),
          new PlayNote(Notes.D5, 76.43578725f, 0.07638812500000824f),
          new PlayNote(Notes.D5, 76.65800725000001f, 0.0694437499999907f),
          new PlayNote(Notes.B4, 76.86633850000001f, 0.0902768750000007f),
          new PlayNote(Notes.D5, 76.873282875f, 0.07638812500000824f),
          new PlayNote(Notes.D5, 77.09550287500001f, 0.07638812499999403f),
          new PlayNote(Notes.D5, 77.317722875f, 0.06944375000000491f),
          new PlayNote(Notes.B4, 77.32466725f, 0.0902768750000007f),
          new PlayNote(Notes.D5, 77.54688725000001f, 0.0694437499999907f),
          new PlayNote(Notes.D5, 77.76910725f, 0.07638812500000824f),
          new PlayNote(Notes.B4, 77.77605162500001f, 0.08333249999999737f),
          new PlayNote(Notes.D5, 77.998271625f, 0.07638812500000824f),
          new PlayNote(Notes.E5, 78.22743600000001f, 0.08333249999999737f),
          new PlayNote(Notes.A4, 78.234380375f, 0.08333250000001158f),
          new PlayNote(Notes.E5, 78.449656f, 0.07638812500000824f),
          new PlayNote(Notes.A4, 78.45660037500001f, 0.07638812499999403f),
          new PlayNote(Notes.E5, 78.67187600000001f, 0.08333249999999737f),
          new PlayNote(Notes.A4, 78.678820375f, 0.07638812500000824f),
          new PlayNote(Notes.E5, 78.894096f, 0.07638812500000824f),
          new PlayNote(Notes.A4, 78.90104037500001f, 0.08333249999999737f),
          new PlayNote(Notes.E5, 79.11631600000001f, 0.07638812499999403f),
          new PlayNote(Notes.E5, 79.338536f, 0.07638812500000824f),
          new PlayNote(Notes.E5, 79.56075600000001f, 0.07638812499999403f),
          new PlayNote(Notes.E5, 79.782976f, 0.06944375000000491f),
          new PlayNote(Notes.E5, 79.99825162500001f, 0.07638812499999403f),
          new PlayNote(Notes.A4, 80.00519600000001f, 0.07638812499999403f),
          new PlayNote(Notes.E5, 80.220471625f, 0.08333250000001158f),
          new PlayNote(Notes.A4, 80.227416f, 0.07638812500000824f),
          new PlayNote(Notes.E5, 80.44269162500001f, 0.08333249999999737f),
          new PlayNote(Notes.A4, 80.44963600000001f, 0.0902768750000007f),
          new PlayNote(Notes.E5, 80.664911625f, 0.0902768750000007f),
          new PlayNote(Notes.A4, 80.67880037500001f, 0.08333249999999737f),
          new PlayNote(Notes.Fs5, 80.89407600000001f, 0.08333249999999737f),
          new PlayNote(Notes.A4, 80.901020375f, 0.07638812500000824f),
          new PlayNote(Notes.Fs5, 81.109351625f, 0.08333250000001158f),
          new PlayNote(Notes.A4, 81.116296f, 0.07638812500000824f),
          new PlayNote(Notes.Fs5, 81.33157162500001f, 0.07638812499999403f),
          new PlayNote(Notes.Fs5, 81.54684725000001f, 0.07638812499999403f),
          new PlayNote(Notes.Fs5, 81.76906725f, 0.08333249999999737f),
          new PlayNote(Notes.Fs5, 81.99128725000001f, 0.09027687499998649f),
          new PlayNote(Notes.Fs5, 82.21350725f, 0.08333249999999737f),
          new PlayNote(Notes.Fs5, 82.442671625f, 0.08333250000001158f),
          new PlayNote(Notes.Fs5, 82.66489162500001f, 0.0902768750000007f),
          new PlayNote(Notes.Fs5, 82.887111625f, 0.08333249999999737f),
          new PlayNote(Notes.Fs5, 83.10933162500001f, 0.0902768750000007f),
          new PlayNote(Notes.Fs5, 83.338496f, 0.08333249999999737f),
          new PlayNote(Notes.G5, 83.56071600000001f, 0.0902768750000007f),
          new PlayNote(Notes.B4, 83.782936f, 0.08333249999999737f),
          new PlayNote(Notes.G5, 83.78988037500001f, 0.0902768750000007f),
          new PlayNote(Notes.G5, 84.00515600000001f, 0.09027687499998649f),
          new PlayNote(Notes.B4, 84.227376f, 0.0902768750000007f),
          new PlayNote(Notes.G5, 84.23432037500001f, 0.07638812499999403f),
          new PlayNote(Notes.B4, 84.44959600000001f, 0.0902768750000007f),
          new PlayNote(Notes.G5, 84.456540375f, 0.07638812500000824f),
          new PlayNote(Notes.B4, 84.671816f, 0.0902768750000007f),
          new PlayNote(Notes.G5, 84.68570475000001f, 0.08333249999999737f),
          new PlayNote(Notes.G5, 84.900980375f, 0.08333249999999737f),
          new PlayNote(Notes.G5, 85.109311625f, 0.07638812500000824f),
          new PlayNote(Notes.B4, 85.116256f, 0.08333249999999737f),
          new PlayNote(Notes.G5, 85.33153162500001f, 0.07638812499999403f),
          new PlayNote(Notes.B4, 85.345420375f, 0.0902768750000007f),
          new PlayNote(Notes.G5, 85.553751625f, 0.07638812500000824f),
          new PlayNote(Notes.B4, 85.56764037500001f, 0.0902768750000007f),
          new PlayNote(Notes.G5, 85.77597162500001f, 0.0902768750000007f),
          new PlayNote(Notes.B4, 85.782916f, 0.07638812500000824f),
          new PlayNote(Notes.G5, 85.998191625f, 0.08333249999999737f),
          new PlayNote(Notes.B4, 86.00513600000001f, 0.07638812499999403f),
          new PlayNote(Notes.Cs5, 86.22041162500001f, 0.08333249999999737f),
          new PlayNote(Notes.Gs5, 86.22735600000001f, 0.07638812499999403f),
          new PlayNote(Notes.Cs5, 86.442631625f, 0.08333249999999737f),
          new PlayNote(Notes.Gs5, 86.44957600000001f, 0.08333249999999737f),
          new PlayNote(Notes.Gs5, 86.66485162500001f, 0.07638812499999403f),
          new PlayNote(Notes.Gs5, 86.88012725f, 0.08333250000001158f),
          new PlayNote(Notes.Gs5, 87.10234725000001f, 0.08333249999999737f),
          new PlayNote(Notes.Cs5, 87.10929162500001f, 0.08333249999999737f),
          new PlayNote(Notes.Gs5, 87.32456725f, 0.0902768750000007f),
          new PlayNote(Notes.As5, 87.54678725000001f, 0.06944375000000491f),
          new PlayNote(Notes.Cs5, 87.55373162500001f, 0.07638812499999403f),
          new PlayNote(Notes.As5, 87.76900725000002f, 0.09027687499998649f),
          new PlayNote(Notes.Cs5, 87.78289600000001f, 0.07638812499999403f),
          new PlayNote(Notes.Cs5, 87.99817162500001f, 0.0902768750000007f),
          new PlayNote(Notes.Fs5, 88.220391625f, 0.08333249999999737f),
          new PlayNote(Notes.D5, 88.22733600000001f, 0.08333249999999737f),
          new PlayNote(Notes.Fs5, 88.44261162500001f, 0.0902768750000007f),
          new PlayNote(Notes.B4, 88.65788725f, 0.08333250000001158f),
          new PlayNote(Notes.D5, 88.664831625f, 0.08333249999999737f),
          new PlayNote(Notes.A4, 88.873162875f, 0.0946390000000008f),
          new PlayNote(Notes.E5, 88.88010725000001f, 0.07423624999999845f),
          new PlayNote(Notes.A4, 89.09565643750001f, 0.08075024999999414f),
          new PlayNote(Notes.E5, 89.10238562500001f, 0.07402106249999463f),
          new PlayNote(Notes.E5, 89.31099043750001f, 0.08075025000000835f),
          new PlayNote(Notes.A4, 89.52632443750001f, 0.08075025000000835f),
          new PlayNote(Notes.E5, 89.53305362500001f, 0.07402106250000884f),
          new PlayNote(Notes.A4, 89.7416584375f, 0.08075025000000835f),
          new PlayNote(Notes.E5, 89.748387625f, 0.06729187500000933f),
          new PlayNote(Notes.E5, 89.9569924375f, 0.07402106250000884f),
          new PlayNote(Notes.A4, 89.963721625f, 0.07402106250000884f),
          new PlayNote(Notes.A4, 90.17232643750002f, 0.08747943749999365f),
          new PlayNote(Notes.E5, 90.17905562500002f, 0.06729187499999512f),
          new PlayNote(Notes.E5, 90.38766043750002f, 0.07402106249999463f),
          new PlayNote(Notes.A4, 90.39438962500002f, 0.08075024999999414f),
          new PlayNote(Notes.E5, 90.58953606250002f, 0.06729187499999512f),
          new PlayNote(Notes.A4, 90.60972362500002f, 0.08075024999999414f),
          new PlayNote(Notes.E5, 90.80487006250002f, 0.06729187499999512f),
          new PlayNote(Notes.A4, 90.82505762500001f, 0.08075024999999414f),
          new PlayNote(Notes.E5, 91.02020406250001f, 0.060562687499995604f),
          new PlayNote(Notes.A4, 91.04039162500001f, 0.08075024999999414f),
          new PlayNote(Notes.E5, 91.23553806250001f, 0.06729187499999512f),
          new PlayNote(Notes.A4, 91.25572562500001f, 0.08075025000000835f),
          new PlayNote(Notes.Fs5, 91.45760125000001f, 0.060562687499995604f),
          new PlayNote(Notes.A4, 91.47105962500001f, 0.08075025000000835f),
          new PlayNote(Notes.Fs5, 91.67966443750001f, 0.08747943750000786f),
          new PlayNote(Notes.A4, 91.68639362500001f, 0.08075025000000835f),
          new PlayNote(Notes.A4, 91.8949984375f, 0.08075025000000835f),
          new PlayNote(Notes.Fs5, 91.901727625f, 0.07402106250000884f),
          new PlayNote(Notes.A4, 92.11706162500002f, 0.07402106249999463f),
          new PlayNote(Notes.Fs5, 92.12379081250002f, 0.08075024999999414f),
          new PlayNote(Notes.Fs5, 92.33239562500002f, 0.08075024999999414f),
          new PlayNote(Notes.Fs5, 92.54100043750002f, 0.08747943749999365f),
          new PlayNote(Notes.Fs5, 92.76306362500002f, 0.07402106249999463f),
          new PlayNote(Notes.Fs5, 92.97839762500001f, 0.07402106249999463f),
          new PlayNote(Notes.Fs5, 93.18700243750001f, 0.08075024999999414f),
          new PlayNote(Notes.A4, 93.19373162500001f, 0.07402106249999463f),
          new PlayNote(Notes.Fs5, 93.40832712500001f, 0.07916149999999789f),
          new PlayNote(Notes.Fs5, 93.61282766666667f, 0.0791615000000121f),
          new PlayNote(Notes.A4, 93.61942445833334f, 0.0791615000000121f),
          new PlayNote(Notes.Fs5, 93.83052179166668f, 0.07916149999999789f),
          new PlayNote(Notes.G5, 94.04161912500001f, 0.08575829166666438f),
          new PlayNote(Notes.B4, 94.25271645833335f, 0.0725647083333314f),
          new PlayNote(Notes.G5, 94.25931325000002f, 0.08575829166666438f),
          new PlayNote(Notes.B4, 94.45721700000001f, 0.07916149999999789f),
          new PlayNote(Notes.G5, 94.47700737500001f, 0.08575829166666438f),
          new PlayNote(Notes.G4, 94.67491112500001f, 0.08575829166667859f),
          new PlayNote(Notes.E5, 94.68150791666667f, 0.06596791666667912f),
          new PlayNote(Notes.G4, 94.88600845833335f, 0.07916149999999789f),
          new PlayNote(Notes.E5, 94.89260525000002f, 0.0725647083333314f),
          new PlayNote(Notes.G4, 95.09710579166668f, 0.08575829166666438f),
          new PlayNote(Notes.F5, 95.30820312500002f, 0.0725647083333314f),
          new PlayNote(Notes.G4, 95.31479991666669f, 0.07916149999999789f),
          new PlayNote(Notes.G4, 95.51930045833335f, 0.07916149999999789f),
          new PlayNote(Notes.F5, 95.72380100000001f, 0.06596791666667912f),
          new PlayNote(Notes.G4, 95.73039779166668f, 0.0725647083333456f),
          new PlayNote(Notes.G4, 95.93489833333335f, 0.08575829166666438f),
          new PlayNote(Notes.G4, 96.14599566666668f, 0.08575829166666438f),
          new PlayNote(Notes.G4, 96.35709300000002f, 0.0725647083333314f),
          new PlayNote(Notes.G5, 96.56819033333335f, 0.0659679166666649f),
          new PlayNote(Notes.E5, 96.57478712500001f, 0.08575829166666438f),
          new PlayNote(Notes.G5, 96.78588445833334f, 0.0725647083333314f),
          new PlayNote(Notes.E5, 96.79248125000001f, 0.0791615000000121f),
          new PlayNote(Notes.G5, 96.99038500000002f, 0.07916149999999789f),
          new PlayNote(Notes.E5, 96.99698179166668f, 0.07916149999999789f),
          new PlayNote(Notes.G5, 97.20807912500001f, 0.07916149999999789f),
          new PlayNote(Notes.G5, 97.41917645833335f, 0.07916149999999789f),
          new PlayNote(Notes.G5, 97.62367700000001f, 0.0725647083333314f),
          new PlayNote(Notes.G5, 97.83477433333334f, 0.0659679166666649f),
          new PlayNote(Notes.G5, 98.04587166666668f, 0.0725647083333314f),
          new PlayNote(Notes.E5, 98.25037220833335f, 0.0725647083333314f),
          new PlayNote(Notes.G5, 98.25696900000001f, 0.0725647083333314f),
          new PlayNote(Notes.E5, 98.46146954166669f, 0.0725647083333314f),
          new PlayNote(Notes.G5, 98.46806633333335f, 0.0725647083333314f),
          new PlayNote(Notes.E5, 98.67256687500002f, 0.0725647083333314f),
          new PlayNote(Notes.G5, 98.67916366666668f, 0.0725647083333314f),
          new PlayNote(Notes.E5, 98.88366420833334f, 0.0725647083333314f),
          new PlayNote(Notes.G5, 98.89026100000001f, 0.0725647083333314f),
          new PlayNote(Notes.Cs5, 99.09476154166668f, 0.0725647083333314f),
          new PlayNote(Notes.Fs5, 99.10135833333335f, 0.0659679166666649f),
          new PlayNote(Notes.Cs5, 99.31245566666668f, 0.0659679166666649f),
          new PlayNote(Notes.Fs5, 99.31905245833335f, 0.0659679166666649f),
          new PlayNote(Notes.Fs5, 99.52355300000002f, 0.0659679166666649f),
          new PlayNote(Notes.Fs5, 99.73465033333335f, 0.0725647083333314f),
          new PlayNote(Notes.Fs5, 99.94574766666668f, 0.07916149999999789f),
          new PlayNote(Notes.Fs5, 100.15684500000002f, 0.0725647083333314f),
          new PlayNote(Notes.G5, 100.37453912500001f, 0.07916149999999789f),
          new PlayNote(Notes.G5, 100.57903966666669f, 0.0725647083333314f),
          new PlayNote(Notes.G5, 100.78354020833335f, 0.0725647083333314f),
          new PlayNote(Notes.E5, 100.79013700000002f, 0.0659679166666649f),
          new PlayNote(Notes.G5, 100.99463754166668f, 0.059371124999998415f),
          new PlayNote(Notes.E5, 101.00123433333334f, 0.0725647083333314f),
          new PlayNote(Notes.G5, 101.21233166666669f, 0.0659679166666649f),
          new PlayNote(Notes.G5, 101.41683220833335f, 0.0659679166666649f),
          new PlayNote(Notes.E5, 101.42342900000001f, 0.0725647083333314f),
          new PlayNote(Notes.G5, 101.63452633333335f, 0.0659679166666649f),
          new PlayNote(Notes.E5, 101.64112312500001f, 0.06596791666667912f),
          new PlayNote(Notes.G5, 101.84562366666668f, 0.0659679166666649f),
          new PlayNote(Notes.G5, 102.05672100000001f, 0.0725647083333314f),
          new PlayNote(Notes.E5, 102.06331779166668f, 0.0659679166666649f),
          new PlayNote(Notes.G5, 102.27441512500002f, 0.0725647083333314f),
          new PlayNote(Notes.G5, 102.47891566666668f, 0.0659679166666649f),
          new PlayNote(Notes.E5, 102.48551245833335f, 0.0725647083333314f),
          new PlayNote(Notes.G5, 102.67681941666669f, 0.07256470833331718f),
          new PlayNote(Notes.E5, 102.69660979166667f, 0.0791615000000121f),
          new PlayNote(Notes.G5, 102.90111033333335f, 0.0725647083333314f),
          new PlayNote(Notes.E5, 102.91430391666668f, 0.0725647083333314f),
          new PlayNote(Notes.G5, 103.11880445833334f, 0.0659679166666649f),
          new PlayNote(Notes.E5, 103.12540125000001f, 0.0659679166666649f),
          new PlayNote(Notes.G5, 103.32330500000002f, 0.0659679166666649f),
          new PlayNote(Notes.E5, 103.32990179166669f, 0.0725647083333314f),
          new PlayNote(Notes.G5, 103.53440233333335f, 0.07916149999999789f),
          new PlayNote(Notes.E5, 103.54099912500001f, 0.0725647083333314f),
          new PlayNote(Notes.G5, 103.74549966666667f, 0.0725647083333456f),
          new PlayNote(Notes.E5, 103.75209645833334f, 0.0725647083333456f),
          new PlayNote(Notes.G5, 103.96319379166668f, 0.07916149999999789f),
          new PlayNote(Notes.Fs5, 104.17429112500001f, 0.0659679166666649f),
          new PlayNote(Notes.Fs5, 104.38538845833335f, 0.07916149999999789f),
          new PlayNote(Notes.Fs5, 104.59648579166668f, 0.07916149999999789f),
          new PlayNote(Notes.Fs5, 104.80758312500001f, 0.0791615000000121f),
          new PlayNote(Notes.Fs5, 105.01868045833335f, 0.0725647083333314f),
          new PlayNote(Notes.Fs5, 105.22318100000001f, 0.08575829166666438f),
          new PlayNote(Notes.Cs5, 105.22977779166668f, 0.0659679166666649f),
          new PlayNote(Notes.G5, 105.44087512500002f, 0.07916149999999789f),
          new PlayNote(Notes.E5, 105.44747191666669f, 0.0725647083333314f),
          new PlayNote(Notes.G5, 105.65197245833335f, 0.07916149999999789f),
          new PlayNote(Notes.E5, 105.65856925000001f, 0.0659679166666649f),
          new PlayNote(Notes.G5, 105.86306979166667f, 0.08575829166667859f),
          new PlayNote(Notes.E5, 105.86966658333334f, 0.0725647083333314f),
          new PlayNote(Notes.G5, 106.07416712500002f, 0.08575829166666438f),
          new PlayNote(Notes.E5, 106.08076391666668f, 0.0725647083333314f),
          new PlayNote(Notes.G5, 106.27866766666668f, 0.08575829166666438f),
          new PlayNote(Notes.E5, 106.29186125000001f, 0.0725647083333314f),
          new PlayNote(Notes.G5, 106.48316820833335f, 0.09235508333333087f),
          new PlayNote(Notes.E5, 106.49636179166669f, 0.07916149999999789f),
          new PlayNote(Notes.G5, 106.70086233333335f, 2.5463615833333364f),
          new PlayNote(Notes.E5, 109.24722391666668f, 2.513377625000004f),
          new PlayNote(Notes.G5, 111.76060154166669f, 2.546361583333322f),
          new PlayNote(Notes.E5, 114.30696312500001f, 2.5199744166666704f),
          new PlayNote(Notes.G5, 116.82693754166668f, 2.5463615833333364f),
          new PlayNote(Notes.G5, 119.37329912500002f, 2.526571208333337f),
          new PlayNote(Notes.Gs5, 121.89987033333335f, 2.546361583333322f),
          new PlayNote(Notes.As5, 124.44623191666668f, 2.513377625000004f),
          new PlayNote(Notes.As5, 126.95960954166668f, 1.3127615416666742f),
          new PlayNote(Notes.As5, 128.27237108333335f, 1.2533904166666616f),
          new PlayNote(Notes.As5, 129.52576150000002f, 1.2599872083333423f),
          new PlayNote(Notes.As5, 130.78574870833336f, 1.3061647499999935f),
          new PlayNote(Notes.D6, 142.19819829166667f, 3.2390247083333463f),
          new PlayNote(Notes.D5, 148.49813433333335f, 1.3457454999999925f),
          new PlayNote(Notes.B4, 151.03130233333334f, 1.2995679583333413f),
          new PlayNote(Notes.D5, 151.03789912500002f, 1.3061647499999935f),
          new PlayNote(Notes.D5, 152.91798475000002f, 0.6662759583333298f),
          new PlayNote(Notes.B4, 152.93777512500003f, 0.6003080416666364f),
          new PlayNote(Notes.B4, 154.17797195833333f, 0.6135016250000263f),
          new PlayNote(Notes.D5, 154.19776233333334f, 0.6332919999999831f),
          new PlayNote(Notes.D5, 155.45774954166666f, 0.6794695416666912f),
          new PlayNote(Notes.B4, 155.47094312500002f, 0.6200984166666501f),
          new PlayNote(Notes.B4, 156.737527125f, 0.6266952083333308f),
          new PlayNote(Notes.D5, 156.74412391666667f, 0.6860663333333434f),
          new PlayNote(Notes.B4, 158.004111125f, 0.6398887916666638f),
          new PlayNote(Notes.D5, 158.01070791666666f, 0.6662759583333582f),
          new PlayNote(Notes.D5, 159.25750154166667f, 0.6596791666666775f),
          new PlayNote(Notes.B4, 159.26409833333335f, 0.6332920000000115f),
          new PlayNote(Notes.D5, 160.54387591666668f, 0.6398887916666638f),
          new PlayNote(Notes.D5, 161.80386312500002f, 0.46837220833333504f),
          new PlayNote(Notes.Fs5, 162.45694550000002f, 2.5199744166666562f),
          new PlayNote(Notes.B4, 164.97691991666667f, 0.6398887916666638f),
          new PlayNote(Notes.Cs5, 165.61680870833334f, 0.6135016250000263f),
          new PlayNote(Notes.D5, 166.23031033333336f, 0.6332919999999831f),
          new PlayNote(Notes.E5, 166.86360233333335f, 0.6332919999999831f),
          new PlayNote(Notes.Fs5, 167.49689433333333f, 1.8998760000000061f),
          new PlayNote(Notes.D5, 169.39677033333334f, 0.6464855833333445f),
          new PlayNote(Notes.Fs5, 170.04325591666668f, 1.8866824166666447f),
          new PlayNote(Notes.D5, 171.92993833333333f, 0.4881625833333487f),

        }
        );
    }
}