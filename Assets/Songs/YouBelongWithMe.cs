
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouBelongWithMe : SongScript
{
    public override Song GetSong()
    {
        return new Song(
        3,
        44,
        new List<PlayNote> 
        {
          new PlayNote(Notes.Cs4, 11.073065849999999f, 0.399999600000001f),
          new PlayNote(Notes.As3, 11.534603849999998f, 0.11923065000000044f),
          new PlayNote(Notes.As3, 11.765372849999999f, 0.18846134999999897f),
          new PlayNote(Notes.Gs3, 12.003834149999998f, 0.43076880000000095f),
          new PlayNote(Notes.Fs3, 12.457679849999998f, 0.14999985000000038f),
          new PlayNote(Notes.Fs3, 12.692294999999998f, 0.16538445000000124f),
          new PlayNote(Notes.Cs4, 12.919217849999999f, 0.3730765500000004f),
          new PlayNote(Notes.As3, 13.388448149999999f, 0.3115381500000005f),
          new PlayNote(Notes.Gs3, 13.846139999999998f, 0.18846135000000075f),
          new PlayNote(Notes.As3, 14.080755149999998f, 0.3769226999999997f),
          new PlayNote(Notes.Gs3, 14.534600849999999f, 0.4307687999999992f),
          new PlayNote(Notes.Gs3, 14.996138849999998f, 0.18846135000000075f),
          new PlayNote(Notes.Cs4, 15.226907849999998f, 0.18076905000000032f),
          new PlayNote(Notes.Cs4, 15.457676849999999f, 0.18461519999999965f),
          new PlayNote(Notes.As3, 15.692291999999998f, 0.13461524999999952f),
          new PlayNote(Notes.As3, 15.919214849999998f, 0.17692289999999922f),
          new PlayNote(Notes.Gs3, 16.15383f, 0.3461534999999998f),
          new PlayNote(Notes.Cs4, 16.619214149999998f, 0.18076904999999854f),
          new PlayNote(Notes.As3, 16.849983149999996f, 0.36538425000000174f),
          new PlayNote(Notes.Gs3, 17.311521149999997f, 0.32692275000000137f),
          new PlayNote(Notes.As3, 17.769212999999997f, 0.3499996500000009f),
          new PlayNote(Notes.Gs3, 18.226904849999997f, 0.4269226500000016f),
          new PlayNote(Notes.Gs3, 18.688442849999998f, 0.18076904999999854f),
          new PlayNote(Notes.B3, 18.919211849999996f, 0.41153805000000077f),
          new PlayNote(Notes.As3, 19.380749849999997f, 0.18846135000000075f),
          new PlayNote(Notes.Fs3, 19.61151885f, 0.3192304499999956f),
          new PlayNote(Notes.Gs3, 20.30382585f, 0.16538444999999768f),
          new PlayNote(Notes.As3, 20.534594849999998f, 0.37307654999999684f),
          new PlayNote(Notes.As3, 21.003825149999997f, 0.3961534499999999f),
          new PlayNote(Notes.Gs3, 21.45767085f, 0.1923074999999983f),
          new PlayNote(Notes.Fs3, 21.688439849999998f, 0.35384579999999843f),
          new PlayNote(Notes.Gs3, 22.14997785f, 0.846153000000001f),
          new PlayNote(Notes.As3, 23.073053849999997f, 0.776922299999999f),
          new PlayNote(Notes.Cs4, 25.842281849999996f, 0.41153805000000077f),
          new PlayNote(Notes.As3, 26.303819849999996f, 0.13461524999999952f),
          new PlayNote(Notes.As3, 26.53458885f, 0.19615364999999585f),
          new PlayNote(Notes.Gs3, 26.765357849999997f, 0.36153810000000064f),
          new PlayNote(Notes.Fs3, 27.234588149999997f, 0.16153830000000013f),
          new PlayNote(Notes.Fs3, 27.457664849999997f, 0.176922900000001f),
          new PlayNote(Notes.Cs4, 27.688433849999996f, 0.18461519999999965f),
          new PlayNote(Notes.Cs4, 27.919202849999998f, 0.17692289999999744f),
          new PlayNote(Notes.As3, 28.149971849999996f, 0.35769194999999954f),
          new PlayNote(Notes.Gs3, 28.611509849999997f, 0.176922900000001f),
          new PlayNote(Notes.As3, 28.84997115f, 0.40384574999999856f),
          new PlayNote(Notes.Gs3, 29.311509149999996f, 0.39615344999999635f),
          new PlayNote(Notes.Gs3, 29.765354849999994f, 0.18076905000000565f),
          new PlayNote(Notes.Cs4, 29.996123849999993f, 0.12307680000000687f),
          new PlayNote(Notes.Cs4, 30.226892849999995f, 0.176922900000001f),
          new PlayNote(Notes.As3, 30.457661849999994f, 0.13846140000000418f),
          new PlayNote(Notes.As3, 30.688430849999992f, 0.18076905000000565f),
          new PlayNote(Notes.Gs3, 30.919199849999995f, 0.1615383000000037f),
          new PlayNote(Notes.Gs3, 31.149968849999993f, 0.18076905000000565f),
          new PlayNote(Notes.Cs4, 31.380737849999992f, 0.12692295000000442f),
          new PlayNote(Notes.Cs4, 31.611506849999994f, 0.15769214999999903f),
          new PlayNote(Notes.As3, 31.842275849999993f, 0.4115380500000043f),
          new PlayNote(Notes.Gs3, 32.30381384999999f, 0.21153825000001092f),
          new PlayNote(Notes.As3, 32.53458284999999f, 0.4230765000000005f),
          new PlayNote(Notes.Gs3, 32.99612084999999f, 0.3692304000000064f),
          new PlayNote(Notes.Fs3, 33.457658849999994f, 0.1615383000000037f),
          new PlayNote(Notes.B3, 33.68842785f, 0.403845749999995f),
          new PlayNote(Notes.As3, 34.149965849999994f, 0.22307670000000002f),
          new PlayNote(Notes.Fs3, 34.380734849999996f, 0.399999600000001f),
          new PlayNote(Notes.Gs3, 35.073041849999996f, 0.2115382500000038f),
          new PlayNote(Notes.As3, 35.31150315f, 0.357691949999996f),
          new PlayNote(Notes.As3, 35.77304115f, 0.3807688499999955f),
          new PlayNote(Notes.Gs3, 36.22688684999999f, 0.2076921000000027f),
          new PlayNote(Notes.Fs3, 36.457655849999995f, 0.3576919500000031f),
          new PlayNote(Notes.Gs3, 36.91919384999999f, 0.8653837499999995f),
          new PlayNote(Notes.As3, 37.842269849999994f, 1.0307681999999971f),
          new PlayNote(Notes.Cs4, 40.38072884999999f, 0.2115382500000038f),
          new PlayNote(Notes.Ds4, 40.61149784999999f, 0.4192303500000065f),
          new PlayNote(Notes.Fs4, 41.07303584999999f, 0.3923073000000059f),
          new PlayNote(Notes.Gs4, 41.534573849999994f, 0.3846150000000037f),
          new PlayNote(Notes.Fs4, 41.99611184999999f, 0.3499996500000009f),
          new PlayNote(Notes.Ds4, 42.457649849999996f, 0.3961534499999999f),
          new PlayNote(Notes.Fs4, 42.91918784999999f, 0.3884611499999977f),
          new PlayNote(Notes.Gs4, 43.38072584999999f, 0.3923073000000059f),
          new PlayNote(Notes.Fs4, 43.842263849999995f, 0.3499996500000009f),
          new PlayNote(Notes.Cs4, 44.30380184999999f, 0.43461495000000383f),
          new PlayNote(Notes.Fs4, 44.76533984999999f, 0.3846150000000037f),
          new PlayNote(Notes.Fs4, 45.226877849999994f, 0.1923074999999983f),
          new PlayNote(Notes.Gs4, 45.45764684999999f, 0.1653844500000048f),
          new PlayNote(Notes.Fs4, 45.69610815f, 0.3692303999999993f),
          new PlayNote(Notes.Gs4, 46.14995384999999f, 0.3692304000000064f),
          new PlayNote(Notes.Gs4, 46.61149184999999f, 0.2076921000000027f),
          new PlayNote(Notes.As4, 46.84226084999999f, 0.2038459500000087f),
          new PlayNote(Notes.Gs4, 47.07302984999999f, 0.3923073000000059f),
          new PlayNote(Notes.Fs4, 47.534567849999995f, 0.4115380500000043f),
          new PlayNote(Notes.Ds4, 47.99610584999999f, 0.1884613500000043f),
          new PlayNote(Notes.Fs4, 48.226874849999994f, 0.09615374999999915f),
          new PlayNote(Notes.Fs4, 48.349951649999994f, 0.09615374999999915f),
          new PlayNote(Notes.Fs4, 48.45764384999999f, 0.1961536500000065f),
          new PlayNote(Notes.Ds4, 48.68841284999999f, 0.2038459500000016f),
          new PlayNote(Notes.Gs4, 48.919181849999994f, 0.32692275000000137f),
          new PlayNote(Notes.Cs4, 49.38071984999999f, 0.1961536500000065f),
          new PlayNote(Notes.Cs4, 49.61148884999999f, 0.1999998000000005f),
          new PlayNote(Notes.Ds4, 49.84225784999999f, 0.2038459500000087f),
          new PlayNote(Notes.Fs4, 50.07302684999999f, 0.1923075000000054f),
          new PlayNote(Notes.Ds4, 50.30379584999999f, 0.2115382500000038f),
          new PlayNote(Notes.Fs4, 50.53456484999999f, 0.3653842500000053f),
          new PlayNote(Notes.Ds4, 51.003795149999995f, 0.16538444999999768f),
          new PlayNote(Notes.Fs4, 51.22687184999999f, 0.1692306000000059f),
          new PlayNote(Notes.Ds4, 51.46533315f, 0.15384599999999438f),
          new PlayNote(Notes.As4, 51.919178849999994f, 0.1923074999999983f),
          new PlayNote(Notes.Gs4, 52.14994784999999f, 0.1692306000000059f),
          new PlayNote(Notes.Gs4, 52.38071684999999f, 0.3461534999999998f),
          new PlayNote(Notes.Fs4, 52.84225484999999f, 0.12307680000000687f),
          new PlayNote(Notes.Fs4, 53.07302384999999f, 0.1692306000000059f),
          new PlayNote(Notes.As4, 53.303792849999994f, 0.1961536499999994f),
          new PlayNote(Notes.Gs4, 53.53456184999999f, 0.14999985000000038f),
          new PlayNote(Notes.Fs4, 53.76533084999999f, 0.11923065000000577f),
          new PlayNote(Notes.Fs4, 53.99609984999999f, 0.31923044999999917f),
          new PlayNote(Notes.Gs4, 54.45763784999999f, 0.1961536500000065f),
          new PlayNote(Notes.Fs4, 54.68840684999999f, 0.176922900000001f),
          new PlayNote(Notes.Fs4, 54.91917584999999f, 0.1961536500000065f),
          new PlayNote(Notes.Gs4, 55.14994484999999f, 0.1923075000000054f),
          new PlayNote(Notes.As4, 55.388406149999994f, 0.3807688499999955f),
          new PlayNote(Notes.Gs4, 55.84225184999999f, 0.2038459500000087f),
          new PlayNote(Notes.As4, 56.07686699999999f, 0.5923070999999993f),
          new PlayNote(Notes.Gs4, 56.76532784999999f, 0.1846152000000032f),
          new PlayNote(Notes.As4, 57.003789149999996f, 0.4038457500000021f),
          new PlayNote(Notes.Gs4, 57.46532714999999f, 0.16538444999999768f),
          new PlayNote(Notes.As4, 57.696096149999995f, 0.13461524999999597f),
          new PlayNote(Notes.As4, 57.91917284999999f, 0.22307670000000002f),
          new PlayNote(Notes.Gs4, 58.14994184999999f, 0.44615340000000003f),
          new PlayNote(Notes.Fs4, 58.61147984999999f, 0.3769227000000086f),
          new PlayNote(Notes.As4, 59.07301784999999f, 0.3999995999999939f),
          new PlayNote(Notes.Gs4, 59.54224814999999f, 0.1846152000000032f),
          new PlayNote(Notes.As4, 59.77301714999999f, 0.523076400000015f),
          new PlayNote(Notes.Gs4, 60.45378569999999f, 0.1961536499999994f),
          new PlayNote(Notes.As4, 60.688400849999994f, 0.3730765500000075f),
          new PlayNote(Notes.Gs4, 61.15378499999999f, 0.1807690500000092f),
          new PlayNote(Notes.As4, 61.38840014999999f, 0.3730765500000004f),
          new PlayNote(Notes.Gs4, 61.84609199999999f, 0.3999996000000081f),
          new PlayNote(Notes.Fs4, 62.303783849999995f, 0.3846149999999895f),
          new PlayNote(Notes.B4, 62.76532185f, 0.6461532000000005f),
          new PlayNote(Notes.As4, 63.46532114999999f, 0.3730765500000075f),
          new PlayNote(Notes.Ds4, 64.14993584999999f, 0.7846145999999976f),
          new PlayNote(Notes.Fs4, 65.07301185f, 0.13461524999999597f),
          new PlayNote(Notes.Fs4, 65.30378085f, 0.12692295000000797f),
          new PlayNote(Notes.Fs4, 65.53454984999999f, 0.1961536499999994f),
          new PlayNote(Notes.Ds4, 65.76531885f, 0.2038459499999874f),
          new PlayNote(Notes.Cs4, 65.99608785f, 0.3884611499999977f),
          new PlayNote(Notes.B4, 66.45762585f, 0.6499993500000016f),
          new PlayNote(Notes.As4, 67.14993285f, 0.580768649999996f),
          new PlayNote(Notes.B3, 67.84223985f, 0.8346145499999977f),
          new PlayNote(Notes.B3, 68.76531585f, 0.11923065000000577f),
          new PlayNote(Notes.B3, 68.99608485f, 0.12307679999999266f),
          new PlayNote(Notes.B3, 69.22685385f, 0.4192303499999923f),
          new PlayNote(Notes.As3, 69.68839185f, 0.14999984999998617f),
          new PlayNote(Notes.As3, 69.91916085f, 0.8192299500000075f),
          new PlayNote(Notes.Cs4, 73.84223385f, 0.3807688499999955f),
          new PlayNote(Notes.As3, 74.30377184999999f, 0.12307679999999266f),
          new PlayNote(Notes.As3, 74.53454085f, 0.1884613499999972f),
          new PlayNote(Notes.Gs3, 74.76530985f, 0.4307687999999956f),
          new PlayNote(Notes.Fs3, 75.23454014999999f, 0.1884613499999972f),
          new PlayNote(Notes.Cs4, 75.46530914999998f, 0.3461534999999998f),
          new PlayNote(Notes.Cs4, 75.91915485f, 0.1846151999999961f),
          new PlayNote(Notes.As3, 76.14992385f, 0.12307679999999266f),
          new PlayNote(Notes.As3, 76.38069284999999f, 0.180769049999995f),
          new PlayNote(Notes.Gs3, 76.61146185f, 0.1961536499999852f),
          new PlayNote(Notes.As3, 76.84223084999999f, 0.4115380499999901f),
          new PlayNote(Notes.Gs3, 77.30376885f, 0.4384610999999978f),
          new PlayNote(Notes.Gs3, 77.76530685f, 0.18076904999998078f),
          new PlayNote(Notes.Cs4, 77.99607585f, 0.13076909999999486f),
          new PlayNote(Notes.Cs4, 78.22684484999999f, 0.16923059999999168f),
          new PlayNote(Notes.As3, 78.45761385f, 0.10769219999998825f),
          new PlayNote(Notes.As3, 78.68838285f, 0.180769049999995f),
          new PlayNote(Notes.Gs3, 78.91915184999999f, 0.13846139999999707f),
          new PlayNote(Notes.Gs3, 79.14992085f, 0.15384599999998727f),
          new PlayNote(Notes.Cs4, 79.38068985f, 0.1999998000000005f),
          new PlayNote(Notes.As3, 79.61145884999999f, 0.24999975000000063f),
          new PlayNote(Notes.Gs3, 80.07299685f, 0.32307659999999316f),
          new PlayNote(Notes.As3, 80.53453485f, 0.3576919500000031f),
          new PlayNote(Notes.Gs3, 80.99607284999999f, 0.6230763000000081f),
          new PlayNote(Notes.B3, 81.68837984999999f, 0.1961536499999994f),
          new PlayNote(Notes.As3, 81.91914885f, 0.1961536499999852f),
          new PlayNote(Notes.B3, 82.14991785f, 0.1846151999999961f),
          new PlayNote(Notes.As3, 82.38068684999999f, 0.15384600000000148f),
          new PlayNote(Notes.B3, 82.61145585f, 0.1961536499999852f),
          new PlayNote(Notes.As3, 82.84222485f, 0.1999998000000005f),
          new PlayNote(Notes.B3, 83.08068614999999f, 0.24230744999999843f),
          new PlayNote(Notes.B3, 83.538378f, 0.1846151999999961f),
          new PlayNote(Notes.Cs4, 83.76530084999999f, 0.14999985000000038f),
          new PlayNote(Notes.Ds4, 83.99606985f, 0.1846151999999961f),
          new PlayNote(Notes.Fs4, 84.22683885f, 0.32307659999999316f),
          new PlayNote(Notes.Gs4, 84.68837685f, 0.46538414999999134f),
          new PlayNote(Notes.Fs4, 85.61145284999999f, 0.13076909999999486f),
          new PlayNote(Notes.Fs4, 85.84222184999999f, 0.2038459500000016f),
          new PlayNote(Notes.Gs4, 86.07299085f, 0.1999998000000005f),
          new PlayNote(Notes.Fs4, 86.30375984999999f, 0.4153842000000054f),
          new PlayNote(Notes.B4, 86.76529785f, 0.4384610999999978f),
          new PlayNote(Notes.As4, 87.22683585f, 0.18076904999998078f),
          new PlayNote(Notes.Gs4, 87.45760485f, 0.1769228999999939f),
          new PlayNote(Notes.Gs4, 87.69221999999999f, 0.1846151999999961f),
          new PlayNote(Notes.Fs4, 87.92683514999999f, 0.3423073499999987f),
          new PlayNote(Notes.F4, 88.38837314999999f, 0.1999998000000005f),
          new PlayNote(Notes.Fs4, 88.61529599999999f, 0.31538430000000517f),
          new PlayNote(Notes.Cs4, 89.07298784999999f, 0.15384600000000148f),
          new PlayNote(Notes.Cs4, 89.30375685f, 0.18076904999998078f),
          new PlayNote(Notes.As3, 89.53452585f, 0.407691899999989f),
          new PlayNote(Notes.Gs3, 89.99990999999999f, 0.1999998000000005f),
          new PlayNote(Notes.Fs3, 90.22683285f, 0.17307674999999278f),
          new PlayNote(Notes.Cs4, 90.45760184999999f, 0.1923074999999983f),
          new PlayNote(Notes.As3, 90.69606314999999f, 0.22692285000000822f),
          new PlayNote(Notes.Gs3, 91.15760114999999f, 0.30384584999998765f),
          new PlayNote(Notes.As3, 91.61913914999998f, 0.3961534500000141f),
          new PlayNote(Notes.Gs3, 92.07298485f, 0.4153842000000054f),
          new PlayNote(Notes.Gs3, 92.53452284999999f, 0.2038459500000016f),
          new PlayNote(Notes.Cs4, 92.76529185f, 0.15769215000000258f),
          new PlayNote(Notes.Cs4, 92.99606084999999f, 0.1846152000000103f),
          new PlayNote(Notes.As3, 93.22682984999999f, 0.14230755000001238f),
          new PlayNote(Notes.As3, 93.45759885f, 0.180769049999995f),
          new PlayNote(Notes.Gs3, 93.68836784999999f, 0.14999985000000038f),
          new PlayNote(Notes.Gs3, 93.91913684999999f, 0.1884613500000114f),
          new PlayNote(Notes.Cs4, 94.14990585f, 0.3730765499999933f),
          new PlayNote(Notes.As3, 94.61144384999999f, 0.1884613500000114f),
          new PlayNote(Notes.As3, 94.84221285f, 0.1961536499999852f),
          new PlayNote(Notes.Gs3, 95.07298184999999f, 0.1961536499999994f),
          new PlayNote(Notes.As3, 95.31144314999999f, 0.3384611999999976f),
          new PlayNote(Notes.Gs3, 95.76528884999999f, 0.4076919000000032f),
          new PlayNote(Notes.Gs3, 96.22682685f, 0.16538444999999058f),
          new PlayNote(Notes.Gs3, 96.45759584999999f, 0.13461524999999597f),
          new PlayNote(Notes.Gs3, 96.68836485f, 0.11923064999999156f),
          new PlayNote(Notes.Gs3, 96.91913385f, 0.2038459500000016f),
          new PlayNote(Notes.As3, 97.14990284999999f, 0.2115382499999896f),
          new PlayNote(Notes.B3, 97.38067185f, 0.1884613499999972f),
          new PlayNote(Notes.Cs4, 97.61144085f, 0.16153829999998948f),
          new PlayNote(Notes.Ds4, 97.84220984999999f, 0.14230754999999817f),
          new PlayNote(Notes.Ds4, 98.07297885f, 0.2192305499999918f),
          new PlayNote(Notes.As4, 98.30374785f, 0.3538457999999878f),
          new PlayNote(Notes.Gs4, 98.76528585f, 0.5615378999999905f),
          new PlayNote(Notes.Gs3, 99.91913084999999f, 0.14999985000000038f),
          new PlayNote(Notes.Gs3, 100.15759214999999f, 0.12307680000000687f),
          new PlayNote(Notes.Gs3, 100.38066884999999f, 0.11923064999999156f),
          new PlayNote(Notes.Gs3, 100.61143784999999f, 0.1923074999999983f),
          new PlayNote(Notes.As3, 100.84220685f, 0.180769049999995f),
          new PlayNote(Notes.B3, 101.07297584999999f, 0.180769049999995f),
          new PlayNote(Notes.Cs4, 101.30374484999999f, 0.1769229000000081f),
          new PlayNote(Notes.Ds4, 101.53451385f, 0.4038457500000021f),
          new PlayNote(Notes.As4, 101.99605184999999f, 0.3730765500000075f),
          new PlayNote(Notes.Gs4, 102.45758984999999f, 0.7038454500000029f),
          new PlayNote(Notes.Ds4, 103.38066584999999f, 0.43076880000000983f),
          new PlayNote(Notes.Fs4, 103.84604999999999f, 0.3576919500000031f),
          new PlayNote(Notes.Gs4, 104.30374185f, 0.4230764999999934f),
          new PlayNote(Notes.Fs4, 104.76527984999998f, 0.3730765500000075f),
          new PlayNote(Notes.Ds4, 105.22681784999999f, 0.44999955000000114f),
          new PlayNote(Notes.Fs4, 105.68835585f, 0.3884611499999977f),
          new PlayNote(Notes.Gs4, 106.14989385f, 0.4192303499999923f),
          new PlayNote(Notes.Fs4, 106.61527799999999f, 0.3769226999999944f),
          new PlayNote(Notes.Cs4, 107.07296984999999f, 0.4115380499999901f),
          new PlayNote(Notes.Fs4, 107.53835399999998f, 0.32307659999999316f),
          new PlayNote(Notes.Fs4, 107.99604584999999f, 0.15769215000000258f),
          new PlayNote(Notes.Gs4, 108.22681485f, 0.17307674999999278f),
          new PlayNote(Notes.Fs4, 108.45758384999999f, 0.3499996500000009f),
          new PlayNote(Notes.Gs4, 108.91912185f, 0.3692303999999922f),
          new PlayNote(Notes.Gs4, 109.38065984999999f, 0.21923055000000602f),
          new PlayNote(Notes.As4, 109.61142885f, 0.16538444999999058f),
          new PlayNote(Notes.Gs4, 109.84219784999999f, 0.3923072999999988f),
          new PlayNote(Notes.Fs4, 110.30373585f, 0.4038457500000021f),
          new PlayNote(Notes.Ds4, 110.76527384999999f, 0.1846152000000103f),
          new PlayNote(Notes.Fs4, 110.99604285f, 0.09615374999998494f),
          new PlayNote(Notes.Fs4, 111.11142734999999f, 0.09615374999999915f),
          new PlayNote(Notes.Fs4, 111.22681184999999f, 0.1923074999999983f),
          new PlayNote(Notes.Ds4, 111.46527314999999f, 0.1846151999999961f),
          new PlayNote(Notes.Gs4, 111.68834985f, 0.29230739999999855f),
          new PlayNote(Notes.Cs4, 112.14988784999998f, 0.13461524999999597f),
          new PlayNote(Notes.Cs4, 112.38065685f, 0.1923074999999983f),
          new PlayNote(Notes.Ds4, 112.61142584999999f, 0.16538444999999058f),
          new PlayNote(Notes.Fs4, 112.84219484999998f, 0.1653844500000048f),
          new PlayNote(Notes.Ds4, 113.07296385f, 0.17307674999999278f),
          new PlayNote(Notes.Fs4, 113.30373284999999f, 0.4230764999999934f),
          new PlayNote(Notes.Ds4, 113.76527085f, 0.1769228999999939f),
          new PlayNote(Notes.Fs4, 113.99603984999999f, 0.13461524999999597f),
          new PlayNote(Notes.Fs4, 114.22680885f, 0.16923059999997747f),
          new PlayNote(Notes.As4, 114.68834684999999f, 0.15769215000000258f),
          new PlayNote(Notes.Gs4, 114.91911585f, 0.11538449999999045f),
          new PlayNote(Notes.Gs4, 115.14988484999999f, 0.31923044999999206f),
          new PlayNote(Notes.Fs4, 115.61142285f, 0.09999990000000025f),
          new PlayNote(Notes.Fs4, 115.84219184999999f, 0.1769228999999939f),
          new PlayNote(Notes.A4, 116.07296084999999f, 0.1923074999999983f),
          new PlayNote(Notes.Gs4, 116.30372985f, 0.2153843999999907f),
          new PlayNote(Notes.Fs4, 116.53449884999999f, 0.13846139999999707f),
          new PlayNote(Notes.Fs4, 116.76526784999999f, 0.30769200000000296f),
          new PlayNote(Notes.Gs4, 117.22680584999999f, 0.21538440000000492f),
          new PlayNote(Notes.Fs4, 117.45757484999999f, 0.10384605000000136f),
          new PlayNote(Notes.Fs4, 117.68834385f, 0.1884613499999972f),
          new PlayNote(Notes.Gs4, 117.91911284999999f, 0.17307674999999278f),
          new PlayNote(Notes.As4, 118.14988184999999f, 0.4115380500000043f),
          new PlayNote(Notes.Gs4, 118.61141984999999f, 0.2076920999999885f),
          new PlayNote(Notes.As4, 118.84218884999999f, 0.5923070999999851f),
          new PlayNote(Notes.Gs4, 119.53449584999998f, 0.22692285000000822f),
          new PlayNote(Notes.As4, 119.77295714999998f, 0.4038457500000021f),
          new PlayNote(Notes.Gs4, 120.23449514999999f, 0.14615369999999928f),
          new PlayNote(Notes.As4, 120.46526414999998f, 0.11923064999999156f),
          new PlayNote(Notes.As4, 120.68834084999999f, 0.1999998000000005f),
          new PlayNote(Notes.Gs4, 120.91910984999998f, 0.4038457500000021f),
          new PlayNote(Notes.Fs4, 121.38064784999999f, 0.4192303499999923f),
          new PlayNote(Notes.As4, 121.84218584999999f, 0.4346149499999967f),
          new PlayNote(Notes.Gs4, 122.31141614999999f, 0.2076920999999885f),
          new PlayNote(Notes.As4, 122.54218514999998f, 0.573076350000008f),
          new PlayNote(Notes.Gs4, 123.22679984999999f, 0.1999998000000005f),
          new PlayNote(Notes.As4, 123.45756884999999f, 0.4230765000000076f),
          new PlayNote(Notes.Gs4, 123.91910684999999f, 0.18461519999998188f),
          new PlayNote(Notes.As4, 124.14987584999999f, 0.4230765000000076f),
          new PlayNote(Notes.Gs4, 124.61141384999999f, 0.4461533999999858f),
          new PlayNote(Notes.Fs4, 125.07295185f, 0.3730765499999933f),
          new PlayNote(Notes.B4, 125.53448984999999f, 0.661537800000005f),
          new PlayNote(Notes.As4, 126.22679684999999f, 0.5576917499999894f),
          new PlayNote(Notes.Ds4, 126.91910384999998f, 0.8576914500000044f),
          new PlayNote(Notes.Fs4, 127.84217985f, 0.13076909999998065f),
          new PlayNote(Notes.Fs4, 128.07294885f, 0.13461524999999597f),
          new PlayNote(Notes.Fs4, 128.30371785f, 0.1923074999999983f),
          new PlayNote(Notes.Ds4, 128.53448684999998f, 0.2192305499999918f),
          new PlayNote(Notes.Cs4, 128.76525585f, 0.31923044999999206f),
          new PlayNote(Notes.B4, 129.22679384999998f, 0.6423070499999994f),
          new PlayNote(Notes.As4, 129.91910084999998f, 0.44999955000000114f),
          new PlayNote(Notes.B3, 130.61140784999998f, 0.6423070499999994f),
          new PlayNote(Notes.Cs4, 131.30371484999998f, 0.9807682500000112f),
          new PlayNote(Notes.As4, 132.9152517f, 0.45384569999998803f),
          new PlayNote(Notes.Gs4, 133.38063584999998f, 0.2076921000000027f),
          new PlayNote(Notes.As4, 133.61140484999999f, 0.6346147499999972f),
          new PlayNote(Notes.Gs4, 134.2998657f, 0.1999998000000005f),
          new PlayNote(Notes.As4, 134.53448085f, 0.3961534500000141f),
          new PlayNote(Notes.Gs4, 134.99986499999997f, 0.1769229000000223f),
          new PlayNote(Notes.As4, 135.23063399999998f, 0.12692294999999376f),
          new PlayNote(Notes.As4, 135.45755684999997f, 0.22307670000000712f),
          new PlayNote(Notes.Gs4, 135.68832584999998f, 0.44999955000000114f),
          new PlayNote(Notes.Fs4, 136.14986384999997f, 0.41153805000001853f),
          new PlayNote(Notes.As4, 136.61140185f, 0.43076880000000983f),
          new PlayNote(Notes.Gs4, 137.07293984999998f, 0.2076921000000027f),
          new PlayNote(Notes.As4, 137.30370885f, 0.6038455499999884f),
          new PlayNote(Notes.Gs4, 137.99601585f, 0.2153843999999765f),
          new PlayNote(Notes.As4, 138.22678485f, 0.4384610999999836f),
          new PlayNote(Notes.Gs4, 138.69601515f, 0.18076904999998078f),
          new PlayNote(Notes.As4, 138.91909185f, 0.30769200000000296f),
          new PlayNote(Notes.Gs4, 139.38062985f, 0.3846149999999966f),
          new PlayNote(Notes.Fs4, 139.84216784999998f, 0.4076919000000032f),
          new PlayNote(Notes.B4, 140.30370585f, 0.6499993499999732f),
          new PlayNote(Notes.As4, 140.99601285f, 0.5923070999999709f),
          new PlayNote(Notes.Ds4, 141.69601214999997f, 0.7538454000000172f),
          new PlayNote(Notes.Fs4, 142.6075497f, 0.13846140000001128f),
          new PlayNote(Notes.Fs4, 142.84216485f, 0.13846140000001128f),
          new PlayNote(Notes.Fs4, 143.07293385f, 0.1923074999999983f),
          new PlayNote(Notes.Ds4, 143.30370284999998f, 0.22692285000002244f),
          new PlayNote(Notes.Cs4, 143.53447185f, 0.34615349999998557f),
          new PlayNote(Notes.B4, 143.99600984999998f, 0.665383950000006f),
          new PlayNote(Notes.As4, 144.68831684999998f, 0.5923070999999993f),
          new PlayNote(Notes.B3, 145.3767777f, 0.8269222499999955f),
          new PlayNote(Notes.B3, 146.30369985f, 0.13076909999998065f),
          new PlayNote(Notes.B3, 146.53446885f, 0.13076909999998065f),
          new PlayNote(Notes.B3, 146.76523784999998f, 0.43846110000001204f),
          new PlayNote(Notes.As3, 147.23446814999997f, 0.157692150000031f),
          new PlayNote(Notes.As3, 147.46523714999998f, 0.5115379500000188f),
          new PlayNote(Notes.B4, 160.38060885f, 0.5846147999999971f),
          new PlayNote(Notes.B4, 161.07291585f, 0.13076909999998065f),
          new PlayNote(Notes.B4, 161.30368485f, 0.11538449999997624f),
          new PlayNote(Notes.B4, 161.53445384999998f, 0.21538440000000492f),
          new PlayNote(Notes.As4, 161.7613767f, 0.2076920999999743f),
          new PlayNote(Notes.Fs4, 161.99599185f, 0.3961534499999857f),
          new PlayNote(Notes.Gs4, 162.45752985f, 0.12692294999999376f),
          new PlayNote(Notes.Gs4, 162.68829885f, 0.13076909999998065f),
          new PlayNote(Notes.Gs4, 162.91906784999998f, 0.1961536500000136f),
          new PlayNote(Notes.Fs4, 163.14983684999999f, 0.1961536500000136f),
          new PlayNote(Notes.Ds4, 163.38829814999997f, 0.3923073000000272f),
          new PlayNote(Notes.Fs4, 163.84214384999999f, 0.2115382499999896f),
          new PlayNote(Notes.Fs4, 164.07291285f, 0.2115382499999896f),
          new PlayNote(Notes.Gs4, 164.30368184999998f, 0.20384595000001582f),
          new PlayNote(Notes.As4, 164.53445084999998f, 0.18846134999998299f),
          new PlayNote(Notes.Gs4, 164.76521985f, 0.2076920999999743f),
          new PlayNote(Notes.Fs4, 164.99598884999997f, 0.22692285000002244f),
          new PlayNote(Notes.Ds4, 165.22675784999998f, 0.3846149999999966f),
          new PlayNote(Notes.Fs4, 165.68829584999997f, 0.1961536500000136f),
          new PlayNote(Notes.Fs4, 165.91906484999998f, 0.1769228999999939f),
          new PlayNote(Notes.Gs4, 166.14983385f, 0.2115382499999896f),
          new PlayNote(Notes.As4, 166.38060284999997f, 0.20384595000001582f),
          new PlayNote(Notes.Gs4, 166.61137184999998f, 0.2038459499999874f),
          new PlayNote(Notes.Fs4, 166.84214085f, 0.16153829999998948f),
          new PlayNote(Notes.Fs4, 167.08060214999998f, 0.3230766000000074f),
          new PlayNote(Notes.Fs4, 167.53444785f, 0.13846140000001128f),
          new PlayNote(Notes.Fs4, 167.76521684999997f, 0.173076750000007f),
          new PlayNote(Notes.Gs4, 167.99598584999998f, 0.1807690500000092f),
          new PlayNote(Notes.As4, 168.22675485f, 0.09615374999998494f),
          new PlayNote(Notes.As4, 168.34213935f, 0.09615374999998494f),
          new PlayNote(Notes.Gs4, 168.45752384999997f, 0.1769229000000223f),
          new PlayNote(Notes.Fs4, 168.68829284999998f, 0.173076750000007f),
          new PlayNote(Notes.Gs4, 168.91906185f, 0.4192303499999923f),
          new PlayNote(Notes.Gs4, 169.61136885f, 0.09615374999998494f),
          new PlayNote(Notes.Gs4, 169.73059949999998f, 0.09615374999998494f),
          new PlayNote(Notes.Gs4, 169.84213784999997f, 0.1961536500000136f),
          new PlayNote(Notes.As4, 170.07290684999998f, 0.1769228999999939f),
          new PlayNote(Notes.Gs4, 170.30367585f, 0.2038459499999874f),
          new PlayNote(Notes.Fs4, 170.53444484999997f, 0.1999998000000005f),
          new PlayNote(Notes.Ds4, 170.76521384999998f, 0.36153809999999f),
          new PlayNote(Notes.Fs4, 171.22675184999997f, 0.15769215000000258f),
          new PlayNote(Notes.Fs4, 171.45752084999998f, 0.19230750000002672f),
          new PlayNote(Notes.Gs4, 171.68828985f, 0.1923074999999983f),
          new PlayNote(Notes.As4, 171.91905884999997f, 0.09615375000001336f),
          new PlayNote(Notes.As4, 172.0382895f, 0.09615374999998494f),
          new PlayNote(Notes.Gs4, 172.14982784999998f, 0.2192305499999918f),
          new PlayNote(Notes.Fs4, 172.38059685f, 0.14999985000000038f),
          new PlayNote(Notes.Ds4, 172.61136584999997f, 0.36153809999999f),
          new PlayNote(Notes.Fs4, 173.07290385f, 0.14999985000000038f),
          new PlayNote(Notes.Fs4, 173.30367285f, 0.16923059999999168f),
          new PlayNote(Notes.Gs4, 173.53444184999998f, 0.1807690500000092f),
          new PlayNote(Notes.As4, 173.76521085f, 0.1769228999999939f),
          new PlayNote(Notes.Gs4, 173.99597985f, 0.1923074999999983f),
          new PlayNote(Notes.Fs4, 174.22674884999998f, 0.14999985000000038f),
          new PlayNote(Notes.Fs4, 174.45751785f, 0.33461504999996805f),
          new PlayNote(Notes.Fs4, 174.91905584999998f, 0.14230754999999817f),
          new PlayNote(Notes.Fs4, 175.14982485f, 0.1999998000000005f),
          new PlayNote(Notes.Gs4, 175.38059385f, 0.2115382499999896f),
          new PlayNote(Notes.Fs4, 175.61136284999998f, 0.2076921000000027f),
          new PlayNote(Notes.Gs4, 175.84213185f, 0.2038459499999874f),
          new PlayNote(Notes.Fs4, 176.07290085f, 0.24230744999997f),
          new PlayNote(Notes.As4, 176.30366984999998f, 0.6192301499999928f),
          new PlayNote(Notes.B4, 176.99597684999998f, 0.11923064999999156f),
          new PlayNote(Notes.As4, 177.11136134999998f, 0.11153835000001777f),
          new PlayNote(Notes.Gs4, 177.22674585f, 1.0076913000000047f),
          new PlayNote(Notes.Ds4, 178.61135984999999f, 0.18076904999998078f),
          new PlayNote(Notes.Ds4, 178.84212885f, 0.1999998000000005f),
          new PlayNote(Notes.Fs4, 179.07289784999998f, 0.3230766000000074f),
          new PlayNote(Notes.Ds4, 179.53443585f, 0.1961536499999852f),
          new PlayNote(Notes.Fs4, 179.76520484999998f, 0.534614849999997f),
          new PlayNote(Notes.Ds4, 180.45751184999997f, 0.18846134999998299f),
          new PlayNote(Notes.Fs4, 180.69212699999997f, 0.3307689000000096f),
          new PlayNote(Notes.Fs4, 181.14981884999997f, 0.1346152500000244f),
          new PlayNote(Notes.Fs4, 181.38058784999998f, 0.173076750000007f),
          new PlayNote(Notes.Fs4, 181.61135685f, 0.18076904999998078f),
          new PlayNote(Notes.Gs4, 181.84212584999997f, 0.3884611499999835f),
          new PlayNote(Notes.As4, 182.30366385f, 0.3769226999999944f),
          new PlayNote(Notes.Gs4, 182.76520184999998f, 0.3884611499999835f),
          new PlayNote(Notes.Fs4, 183.22673984999997f, 0.2076921000000027f),
          new PlayNote(Notes.Gs4, 183.45750884999998f, 0.4230765000000076f),
          new PlayNote(Notes.Fs4, 184.14981584999998f, 0.22692284999999401f),
          new PlayNote(Notes.Gs4, 184.38058485f, 0.3423073499999987f),
          new PlayNote(Notes.Fs4, 184.84212284999998f, 0.15769215000000258f),
          new PlayNote(Notes.Gs4, 185.06904569999998f, 0.3923072999999988f),
          new PlayNote(Notes.Fs4, 185.53442984999998f, 0.346153500000014f),
          new PlayNote(Notes.Fs4, 185.99596784999997f, 0.36153809999999f),
          new PlayNote(Notes.B4, 186.45750585f, 0.6038455499999884f),
          new PlayNote(Notes.As4, 187.14981285f, 0.47307644999997933f),
          new PlayNote(Notes.Ds4, 187.85365829999998f, 0.8615375999999912f),
          new PlayNote(Notes.Fs4, 188.76519584999997f, 0.1884613500000114f),
          new PlayNote(Notes.Fs4, 188.99596484999998f, 0.14230754999999817f),
          new PlayNote(Notes.Fs4, 189.22673385f, 0.18076904999998078f),
          new PlayNote(Notes.Ds4, 189.45750284999997f, 0.1807690500000092f),
          new PlayNote(Notes.Cs4, 189.68827184999998f, 0.36153809999999f),
          new PlayNote(Notes.B4, 190.14980984999997f, 0.6192301499999928f),
          new PlayNote(Notes.As4, 190.84211684999997f, 0.6038455500000168f),
          new PlayNote(Notes.B3, 191.53442385f, 0.6576916500000038f),
          new PlayNote(Notes.Cs4, 192.22673085f, 0.7076915999999756f),
          new PlayNote(Notes.As4, 193.84596f, 0.4115380499999901f),
          new PlayNote(Notes.Gs4, 194.30749799999998f, 0.2076921000000027f),
          new PlayNote(Notes.As4, 194.538267f, 0.5923070999999993f),
          new PlayNote(Notes.Gs4, 195.230574f, 0.22692284999999401f),
          new PlayNote(Notes.As4, 195.46903529999997f, 0.4038457499999879f),
          new PlayNote(Notes.Gs4, 195.93057329999996f, 0.1461537000000135f),
          new PlayNote(Notes.As4, 196.16134229999997f, 0.11923064999999156f),
          new PlayNote(Notes.As4, 196.38441899999998f, 0.1999998000000005f),
          new PlayNote(Notes.Gs4, 196.615188f, 0.4038457499999879f),
          new PlayNote(Notes.Fs4, 197.07672599999998f, 0.41923035000002074f),
          new PlayNote(Notes.As4, 197.53826399999997f, 0.4346149499999967f),
          new PlayNote(Notes.Gs4, 198.00749429999996f, 0.2076921000000027f),
          new PlayNote(Notes.As4, 198.23826329999997f, 0.573076350000008f),
          new PlayNote(Notes.Gs4, 198.92287799999997f, 0.1999998000000005f),
          new PlayNote(Notes.Cs5, 199.15364699999998f, 0.4230765000000076f),
          new PlayNote(Notes.As4, 199.61518499999997f, 0.1846151999999961f),
          new PlayNote(Notes.As4, 199.84595399999998f, 0.4230765000000076f),
          new PlayNote(Notes.Gs4, 200.30749199999997f, 0.4461533999999858f),
          new PlayNote(Notes.Fs4, 200.76903f, 0.3730765499999791f),
          new PlayNote(Notes.B4, 201.23056799999998f, 0.6615377999999907f),
          new PlayNote(Notes.As4, 201.92287499999998f, 0.5576917500000036f),
          new PlayNote(Notes.Ds4, 202.61518199999998f, 0.8576914500000044f),
          new PlayNote(Notes.Fs4, 203.53825799999998f, 0.13076910000000908f),
          new PlayNote(Notes.Fs4, 203.76902699999997f, 0.1346152500000244f),
          new PlayNote(Notes.Fs4, 203.99979599999998f, 0.1923074999999983f),
          new PlayNote(Notes.Ds4, 204.23056499999998f, 0.2192305499999918f),
          new PlayNote(Notes.Cs4, 204.46133399999997f, 0.3192304500000205f),
          new PlayNote(Notes.B4, 204.92287199999998f, 0.6423070499999994f),
          new PlayNote(Notes.As4, 205.61517899999998f, 0.44999955000000114f),
          new PlayNote(Notes.B3, 206.30748599999998f, 0.6423070499999994f),
          new PlayNote(Notes.B3, 207.22671584999998f, 0.11923064999999156f),
          new PlayNote(Notes.B3, 207.45748485f, 0.13846140000001128f),
          new PlayNote(Notes.B3, 207.68825384999997f, 0.3923072999999988f),
          new PlayNote(Notes.As3, 208.14979184999999f, 0.14999985000000038f),
          new PlayNote(Notes.As3, 208.38056084999997f, 1.3653832500000078f),
          new PlayNote(Notes.As4, 210.91901984999998f, 0.10769220000000246f),
          new PlayNote(Notes.As4, 211.14594269999998f, 0.13076909999998065f),
          new PlayNote(Notes.As4, 211.3767117f, 0.4038457499999879f),
          new PlayNote(Notes.Gs4, 211.84209585f, 0.09999989999997183f),
          new PlayNote(Notes.Gs4, 212.0690187f, 0.4269226499999945f),
          new PlayNote(Notes.As4, 212.53055669999998f, 0.3576919500000031f),
          new PlayNote(Notes.As4, 213.68824784999998f, 0.2153843999999765f),
          new PlayNote(Notes.Gs4, 213.91901685f, 0.13846139999998286f),
          new PlayNote(Notes.As4, 214.14978584999997f, 0.24999975000002905f),
          new PlayNote(Notes.Gs4, 214.38055484999998f, 0.173076750000007f),
          new PlayNote(Notes.As4, 214.61132385f, 0.3807688499999813f),
          new PlayNote(Notes.Gs4, 215.07286184999998f, 0.18076904999998078f),
          new PlayNote(Notes.Fs4, 215.30363085f, 0.12307679999997845f),
          new PlayNote(Notes.Fs4, 215.53439984999997f, 0.3576919500000031f),
          new PlayNote(Notes.B4, 215.99593785f, 0.5846147999999687f),
          new PlayNote(Notes.As4, 216.68824485f, 0.48461489999999685f),
          new PlayNote(Notes.Ds4, 217.38055185f, 0.7692299999999932f),
          new PlayNote(Notes.Fs4, 218.30362784999997f, 0.12307680000000687f),
          new PlayNote(Notes.Fs4, 218.5305507f, 0.14230754999999817f),
          new PlayNote(Notes.Fs4, 218.76516585f, 0.2038459499999874f),
          new PlayNote(Notes.Ds4, 218.99593484999997f, 0.1961536500000136f),
          new PlayNote(Notes.Cs4, 219.22670384999998f, 0.3846149999999966f),
          new PlayNote(Notes.B4, 219.68824184999997f, 0.5923070999999993f),
          new PlayNote(Notes.As4, 220.38054884999997f, 0.4461533999999858f),
          new PlayNote(Notes.B3, 221.07285584999997f, 0.8192299499999933f),
          new PlayNote(Notes.B3, 221.99593184999998f, 0.12692294999999376f),
          new PlayNote(Notes.B3, 222.22670085f, 0.13076909999998065f),
          new PlayNote(Notes.B3, 222.45746984999997f, 0.3769227000000228f),
          new PlayNote(Notes.As3, 222.91900784999999f, 0.12307679999997845f),
          new PlayNote(Notes.As3, 223.14977684999997f, 1.319229450000023f),

        }
        );
    }
}
