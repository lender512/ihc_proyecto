
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiestaPagana : SongScript
{
    public override Song GetSong()
    {
        return new Song(
        16,
        14,
        new List<PlayNote> 
        {
          new PlayNote(Notes.B4, 66.844704f, 0.3243240000000043f),
          new PlayNote(Notes.B4, 67.169028f, 0.16216199999999503f),
          new PlayNote(Notes.B4, 67.33118999999999f, 0.3243240000000043f),
          new PlayNote(Notes.B4, 67.655514f, 0.16216199999999503f),
          new PlayNote(Notes.Fs5, 67.81767599999999f, 0.3243240000000043f),
          new PlayNote(Notes.Fs5, 68.142f, 0.16216199999999503f),
          new PlayNote(Notes.Fs5, 68.30416199999999f, 0.3243240000000043f),
          new PlayNote(Notes.Fs5, 68.628486f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 68.79064799999999f, 0.3243240000000043f),
          new PlayNote(Notes.E5, 69.114972f, 0.16216199999999503f),
          new PlayNote(Notes.Fs5, 69.27713399999999f, 0.3243240000000043f),
          new PlayNote(Notes.G5, 69.601458f, 0.16216200000000924f),
          new PlayNote(Notes.Fs5, 69.76362f, 0.32432399999999006f),
          new PlayNote(Notes.B4, 70.087944f, 0.16216199999999503f),
          new PlayNote(Notes.B4, 70.25010599999999f, 0.16216200000000924f),
          new PlayNote(Notes.B4, 70.736592f, 0.32432399999999006f),
          new PlayNote(Notes.B4, 71.06091599999999f, 0.16216199999999503f),
          new PlayNote(Notes.B4, 71.22307799999999f, 0.3243240000000043f),
          new PlayNote(Notes.B4, 71.54740199999999f, 0.16216200000000924f),
          new PlayNote(Notes.Fs5, 71.709564f, 0.32432399999999006f),
          new PlayNote(Notes.Fs5, 72.03388799999999f, 0.16216200000000924f),
          new PlayNote(Notes.Fs5, 72.19605f, 0.16216199999999503f),
          new PlayNote(Notes.Fs5, 72.358212f, 0.16216200000000924f),
          new PlayNote(Notes.Fs5, 72.520374f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 72.682536f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 72.844698f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 73.00685999999999f, 0.16216200000000924f),
          new PlayNote(Notes.E5, 73.169022f, 0.16216199999999503f),
          new PlayNote(Notes.Fs5, 73.331184f, 0.16216200000000924f),
          new PlayNote(Notes.G5, 73.493346f, 0.16216199999999503f),
          new PlayNote(Notes.Fs5, 73.655508f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 74.466318f, 0.16216199999999503f),
          new PlayNote(Notes.A5, 74.62848f, 0.16216199999999503f),
          new PlayNote(Notes.A5, 74.79064199999999f, 0.16216200000000924f),
          new PlayNote(Notes.A5, 74.952804f, 0.16216199999999503f),
          new PlayNote(Notes.A5, 75.114966f, 0.16216199999999503f),
          new PlayNote(Notes.G5, 75.27712799999999f, 0.16216200000000924f),
          new PlayNote(Notes.Fs5, 75.43929f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 75.601452f, 0.16216199999999503f),
          new PlayNote(Notes.A4, 75.76361399999999f, 0.16216200000000924f),
          new PlayNote(Notes.A4, 75.925776f, 0.16216199999999503f),
          new PlayNote(Notes.A4, 76.087938f, 0.3243240000000043f),
          new PlayNote(Notes.A4, 76.412262f, 0.16216199999999503f),
          new PlayNote(Notes.G5, 76.574424f, 0.16216199999999503f),
          new PlayNote(Notes.G5, 76.73658599999999f, 0.16216200000000924f),
          new PlayNote(Notes.G5, 76.898748f, 0.16216199999999503f),
          new PlayNote(Notes.G5, 77.06090999999999f, 0.16216200000000924f),
          new PlayNote(Notes.Fs5, 77.223072f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 77.385234f, 0.16216199999999503f),
          new PlayNote(Notes.D5, 77.54739599999999f, 0.16216199999999503f),
          new PlayNote(Notes.Cs5, 77.70955799999999f, 0.16216200000000924f),
          new PlayNote(Notes.A4, 77.87172f, 0.16216200000000924f),
          new PlayNote(Notes.B4, 78.033882f, 0.32432399999999006f),
          new PlayNote(Notes.A4, 78.358206f, 0.16216199999999503f),
          new PlayNote(Notes.B4, 78.52036799999999f, 0.3243240000000043f),
          new PlayNote(Notes.Cs5, 78.844692f, 0.16216200000000924f),
          new PlayNote(Notes.D5, 79.006854f, 0.32432399999999006f),
          new PlayNote(Notes.Fs5, 79.331178f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 79.49333999999999f, 0.3243240000000043f),
          new PlayNote(Notes.E5, 79.817664f, 0.16216200000000924f),
          new PlayNote(Notes.D5, 79.979826f, 0.32432399999999006f),
          new PlayNote(Notes.E5, 80.30414999999999f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 80.46631199999999f, 0.3243240000000043f),
          new PlayNote(Notes.E5, 80.79063599999999f, 0.16216200000000924f),
          new PlayNote(Notes.D5, 80.952798f, 0.32432399999999006f),
          new PlayNote(Notes.A4, 81.27712199999999f, 0.16216199999999503f),
          new PlayNote(Notes.B4, 81.43928399999999f, 0.9729719999999986f),
          new PlayNote(Notes.B4, 90.68251799999999f, 0.3243240000000043f),
          new PlayNote(Notes.B4, 91.00684199999999f, 0.16216200000000924f),
          new PlayNote(Notes.B4, 91.169004f, 0.32432399999999006f),
          new PlayNote(Notes.B4, 91.49332799999999f, 0.16216199999999503f),
          new PlayNote(Notes.Fs5, 91.65548999999999f, 0.3243240000000185f),
          new PlayNote(Notes.Fs5, 91.979814f, 0.16216199999999503f),
          new PlayNote(Notes.Fs5, 92.141976f, 0.32432399999999006f),
          new PlayNote(Notes.Fs5, 92.46629999999999f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 92.62846199999998f, 0.3243240000000185f),
          new PlayNote(Notes.E5, 92.952786f, 0.16216199999999503f),
          new PlayNote(Notes.Fs5, 93.114948f, 0.32432399999999006f),
          new PlayNote(Notes.G5, 93.43927199999999f, 0.16216200000000924f),
          new PlayNote(Notes.Fs5, 93.601434f, 0.3243240000000043f),
          new PlayNote(Notes.B4, 93.925758f, 0.16216199999999503f),
          new PlayNote(Notes.B4, 94.08792f, 0.16216199999999503f),
          new PlayNote(Notes.B4, 94.574406f, 0.3243240000000043f),
          new PlayNote(Notes.B4, 94.89873f, 0.16216199999999503f),
          new PlayNote(Notes.B4, 95.060892f, 0.32432399999999006f),
          new PlayNote(Notes.B4, 95.38521599999999f, 0.16216200000000924f),
          new PlayNote(Notes.Fs5, 95.547378f, 0.3243240000000043f),
          new PlayNote(Notes.Fs5, 95.871702f, 0.16216199999999503f),
          new PlayNote(Notes.Fs5, 96.033864f, 0.16216199999999503f),
          new PlayNote(Notes.Fs5, 96.19602599999999f, 0.16216200000000924f),
          new PlayNote(Notes.Fs5, 96.358188f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 96.52035f, 0.16216200000000924f),
          new PlayNote(Notes.E5, 96.682512f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 96.844674f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 97.00683599999999f, 0.16216199999999503f),
          new PlayNote(Notes.Fs5, 97.16899799999999f, 0.16216200000000924f),
          new PlayNote(Notes.G5, 97.33116f, 0.16216199999999503f),
          new PlayNote(Notes.Fs5, 97.49332199999999f, 0.16216200000000924f),
          new PlayNote(Notes.E5, 98.304132f, 0.16216200000000924f),
          new PlayNote(Notes.A5, 98.466294f, 0.16216199999999503f),
          new PlayNote(Notes.A5, 98.628456f, 0.16216199999999503f),
          new PlayNote(Notes.A5, 98.790618f, 0.16216199999999503f),
          new PlayNote(Notes.A5, 98.95277999999999f, 0.16216199999999503f),
          new PlayNote(Notes.G5, 99.11494199999999f, 0.16216200000000924f),
          new PlayNote(Notes.Fs5, 99.277104f, 0.16216200000000924f),
          new PlayNote(Notes.E5, 99.439266f, 0.16216199999999503f),
          new PlayNote(Notes.A4, 99.601428f, 0.16216199999999503f),
          new PlayNote(Notes.A4, 99.76359f, 0.16216199999999503f),
          new PlayNote(Notes.A4, 99.92575199999999f, 0.3243240000000043f),
          new PlayNote(Notes.A4, 100.25007599999999f, 0.16216200000000924f),
          new PlayNote(Notes.G5, 100.412238f, 0.16216199999999503f),
          new PlayNote(Notes.G5, 100.5744f, 0.16216199999999503f),
          new PlayNote(Notes.G5, 100.73656199999999f, 0.16216199999999503f),
          new PlayNote(Notes.G5, 100.89872399999999f, 0.16216200000000924f),
          new PlayNote(Notes.Fs5, 101.060886f, 0.16216200000000924f),
          new PlayNote(Notes.E5, 101.223048f, 0.16216199999999503f),
          new PlayNote(Notes.D5, 101.38521f, 0.16216199999999503f),
          new PlayNote(Notes.Cs5, 101.547372f, 0.16216199999999503f),
          new PlayNote(Notes.A4, 101.70953399999999f, 0.16216199999999503f),
          new PlayNote(Notes.B4, 101.87169599999999f, 0.3243240000000185f),
          new PlayNote(Notes.A4, 102.19602f, 0.16216199999999503f),
          new PlayNote(Notes.B4, 102.358182f, 0.32432399999999006f),
          new PlayNote(Notes.Cs5, 102.68250599999999f, 0.16216200000000924f),
          new PlayNote(Notes.D5, 102.844668f, 0.3243240000000043f),
          new PlayNote(Notes.Fs5, 103.168992f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 103.331154f, 0.32432399999999006f),
          new PlayNote(Notes.E5, 103.65547799999999f, 0.16216200000000924f),
          new PlayNote(Notes.D5, 103.81764f, 0.3243240000000043f),
          new PlayNote(Notes.E5, 104.141964f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 104.304126f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 104.46628799999999f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 104.62844999999999f, 0.16216200000000924f),
          new PlayNote(Notes.D5, 104.790612f, 0.3243240000000043f),
          new PlayNote(Notes.A4, 105.114936f, 0.16216199999999503f),
          new PlayNote(Notes.B4, 105.277098f, 0.9729719999999986f),
          new PlayNote(Notes.Fs5, 106.25007f, 0.4864859999999993f),
          new PlayNote(Notes.D5, 106.736556f, 0.4864859999999993f),
          new PlayNote(Notes.B4, 107.22304199999999f, 0.4864859999999993f),
          new PlayNote(Notes.B4, 107.70952799999999f, 0.3243240000000043f),
          new PlayNote(Notes.Fs5, 108.033852f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 108.19601399999999f, 0.4864860000000135f),
          new PlayNote(Notes.Cs5, 108.6825f, 0.4864859999999851f),
          new PlayNote(Notes.A4, 109.16898599999999f, 0.8108100000000036f),
          new PlayNote(Notes.Fs5, 109.979796f, 0.16216199999999503f),
          new PlayNote(Notes.G5, 110.14195799999999f, 0.3243240000000043f),
          new PlayNote(Notes.G5, 110.46628199999999f, 0.16216200000000924f),
          new PlayNote(Notes.G5, 110.628444f, 0.32432399999999006f),
          new PlayNote(Notes.G5, 110.95276799999999f, 0.16216200000000924f),
          new PlayNote(Notes.G5, 111.11493f, 0.32432399999999006f),
          new PlayNote(Notes.G5, 111.43925399999999f, 0.16216200000000924f),
          new PlayNote(Notes.A5, 111.601416f, 0.32432399999999006f),
          new PlayNote(Notes.G5, 111.92573999999999f, 0.16216200000000924f),
          new PlayNote(Notes.Fs5, 112.087902f, 0.32432399999999006f),
          new PlayNote(Notes.E5, 112.41222599999999f, 0.16216200000000924f),
          new PlayNote(Notes.D5, 112.574388f, 0.32432399999999006f),
          new PlayNote(Notes.E5, 112.89871199999999f, 0.16216200000000924f),
          new PlayNote(Notes.Fs5, 113.060874f, 0.6486479999999943f),
          new PlayNote(Notes.Fs5, 113.70952199999999f, 0.16216200000000924f),
          new PlayNote(Notes.Fs5, 113.871684f, 0.16216199999999503f),
          new PlayNote(Notes.Fs5, 114.033846f, 0.3243240000000043f),
          new PlayNote(Notes.Fs5, 114.35817f, 0.16216199999999503f),
          new PlayNote(Notes.Fs5, 114.520332f, 0.3243240000000043f),
          new PlayNote(Notes.G5, 114.844656f, 0.16216199999999503f),
          new PlayNote(Notes.A5, 115.006818f, 0.4864859999999993f),
          new PlayNote(Notes.G5, 115.493304f, 0.3243240000000043f),
          new PlayNote(Notes.Fs5, 115.817628f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 115.97979f, 0.3243240000000043f),
          new PlayNote(Notes.D5, 116.304114f, 0.16216199999999503f),
          new PlayNote(Notes.Cs5, 116.466276f, 0.3243240000000043f),
          new PlayNote(Notes.D5, 116.7906f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 116.95276199999999f, 0.8108100000000036f),
          new PlayNote(Notes.Fs5, 117.763572f, 0.16216199999999503f),
          new PlayNote(Notes.G5, 117.92573399999999f, 0.3243240000000043f),
          new PlayNote(Notes.G5, 118.250058f, 0.16216199999999503f),
          new PlayNote(Notes.D5, 118.41221999999999f, 0.3243240000000043f),
          new PlayNote(Notes.D5, 118.736544f, 0.16216199999999503f),
          new PlayNote(Notes.B4, 118.89870599999999f, 0.3243240000000043f),
          new PlayNote(Notes.B4, 119.22303f, 0.16216199999999503f),
          new PlayNote(Notes.G5, 119.38519199999999f, 0.3243240000000043f),
          new PlayNote(Notes.G5, 119.709516f, 0.16216199999999503f),
          new PlayNote(Notes.Fs5, 119.87167799999999f, 0.4864860000000135f),
          new PlayNote(Notes.E5, 120.358164f, 0.4864859999999993f),
          new PlayNote(Notes.D5, 120.84465f, 0.4864859999999993f),
          new PlayNote(Notes.Cs5, 121.331136f, 0.4864859999999993f),
          new PlayNote(Notes.B4, 121.817622f, 0.16216199999999503f),
          new PlayNote(Notes.B4, 141.277062f, 0.32432399999999006f),
          new PlayNote(Notes.B4, 141.601386f, 0.16216200000002345f),
          new PlayNote(Notes.B4, 141.76354800000001f, 0.32432399999999006f),
          new PlayNote(Notes.B4, 142.087872f, 0.16216199999999503f),
          new PlayNote(Notes.Fs5, 142.250034f, 0.32432399999999006f),
          new PlayNote(Notes.Fs5, 142.574358f, 0.16216199999999503f),
          new PlayNote(Notes.Fs5, 142.73651999999998f, 0.32432399999999006f),
          new PlayNote(Notes.Fs5, 143.06084399999997f, 0.16216200000002345f),
          new PlayNote(Notes.E5, 143.223006f, 0.32432399999999006f),
          new PlayNote(Notes.E5, 143.54733f, 0.16216200000002345f),
          new PlayNote(Notes.Fs5, 143.709492f, 0.32432399999999006f),
          new PlayNote(Notes.G5, 144.033816f, 0.16216199999999503f),
          new PlayNote(Notes.Fs5, 144.195978f, 0.3243240000000185f),
          new PlayNote(Notes.B4, 144.52030200000002f, 0.1621619999999666f),
          new PlayNote(Notes.B4, 144.68246399999998f, 0.16216200000002345f),
          new PlayNote(Notes.B4, 145.16895f, 0.32432399999999006f),
          new PlayNote(Notes.B4, 145.49327399999999f, 0.16216200000002345f),
          new PlayNote(Notes.B4, 145.655436f, 0.32432399999999006f),
          new PlayNote(Notes.B4, 145.97976f, 0.16216199999999503f),
          new PlayNote(Notes.Fs5, 146.141922f, 0.3243240000000185f),
          new PlayNote(Notes.Fs5, 146.466246f, 0.1621619999999666f),
          new PlayNote(Notes.Fs5, 146.62840799999998f, 0.3243240000000185f),
          new PlayNote(Notes.Fs5, 146.952732f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 147.43921799999998f, 0.16216200000002345f),
          new PlayNote(Notes.E5, 147.60138f, 0.16216199999999503f),
          new PlayNote(Notes.D5, 147.763542f, 0.16216199999999503f),
          new PlayNote(Notes.B4, 147.925704f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 148.736514f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 148.898676f, 0.16216199999999503f),
          new PlayNote(Notes.A5, 149.060838f, 0.32432399999999006f),
          new PlayNote(Notes.A5, 149.38516199999998f, 0.16216200000002345f),
          new PlayNote(Notes.G5, 149.547324f, 0.32432399999999006f),
          new PlayNote(Notes.Fs5, 149.871648f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 150.03381f, 0.6486480000000086f),
          new PlayNote(Notes.E5, 150.682458f, 0.16216199999999503f),
          new PlayNote(Notes.Fs5, 150.84462f, 0.16216199999999503f),
          new PlayNote(Notes.G5, 151.006782f, 0.32432399999999006f),
          new PlayNote(Notes.G5, 151.33110599999998f, 0.16216200000002345f),
          new PlayNote(Notes.Fs5, 151.493268f, 0.32432399999999006f),
          new PlayNote(Notes.E5, 151.817592f, 0.16216200000002345f),
          new PlayNote(Notes.D5, 151.979754f, 0.32432399999999006f),
          new PlayNote(Notes.Cs5, 152.304078f, 0.16216199999999503f),
          new PlayNote(Notes.B4, 152.46624f, 0.32432399999999006f),
          new PlayNote(Notes.A4, 152.790564f, 0.16216199999999503f),
          new PlayNote(Notes.B4, 152.95272599999998f, 0.32432399999999006f),
          new PlayNote(Notes.Cs5, 153.27704999999997f, 0.16216200000002345f),
          new PlayNote(Notes.D5, 153.439212f, 0.32432399999999006f),
          new PlayNote(Notes.Fs5, 153.763536f, 0.16216200000002345f),
          new PlayNote(Notes.E5, 153.925698f, 0.32432399999999006f),
          new PlayNote(Notes.E5, 154.250022f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 154.412184f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 154.574346f, 0.32432399999999006f),
          new PlayNote(Notes.B5, 154.89866999999998f, 0.3243240000000185f),
          new PlayNote(Notes.B5, 155.222994f, 0.16216199999999503f),
          new PlayNote(Notes.B5, 155.385156f, 0.16216199999999503f),
          new PlayNote(Notes.B5, 155.547318f, 0.3243240000000185f),
          new PlayNote(Notes.B5, 155.871642f, 0.1621619999999666f),
          new PlayNote(Notes.B4, 156.03380399999998f, 0.16216200000002345f),
          new PlayNote(Notes.Fs5, 156.84461399999998f, 0.4864860000000135f),
          new PlayNote(Notes.D5, 157.3311f, 0.4864860000000135f),
          new PlayNote(Notes.B4, 157.817586f, 0.4864859999999851f),
          new PlayNote(Notes.B4, 158.304072f, 0.3243240000000185f),
          new PlayNote(Notes.Fs5, 158.628396f, 0.1621619999999666f),
          new PlayNote(Notes.E5, 158.79055799999998f, 0.4864860000000135f),
          new PlayNote(Notes.Cs5, 159.277044f, 0.4864860000000135f),
          new PlayNote(Notes.A4, 159.76353f, 0.8108100000000036f),
          new PlayNote(Notes.Fs5, 160.57434f, 0.16216199999999503f),
          new PlayNote(Notes.G5, 160.736502f, 0.32432399999999006f),
          new PlayNote(Notes.G5, 161.060826f, 0.16216199999999503f),
          new PlayNote(Notes.G5, 161.222988f, 0.32432399999999006f),
          new PlayNote(Notes.G5, 161.54731199999998f, 0.16216200000002345f),
          new PlayNote(Notes.G5, 161.709474f, 0.32432399999999006f),
          new PlayNote(Notes.G5, 162.033798f, 0.16216200000002345f),
          new PlayNote(Notes.A5, 162.19596f, 0.32432399999999006f),
          new PlayNote(Notes.G5, 162.520284f, 0.16216199999999503f),
          new PlayNote(Notes.Fs5, 162.682446f, 0.32432399999999006f),
          new PlayNote(Notes.E5, 163.00677f, 0.16216199999999503f),
          new PlayNote(Notes.D5, 163.16893199999998f, 0.3243240000000185f),
          new PlayNote(Notes.E5, 163.493256f, 0.16216199999999503f),
          new PlayNote(Notes.Fs5, 163.655418f, 0.6486479999999801f),
          new PlayNote(Notes.Fs5, 164.30406599999998f, 0.16216200000002345f),
          new PlayNote(Notes.Fs5, 164.466228f, 0.16216199999999503f),
          new PlayNote(Notes.Fs5, 164.62839f, 0.3243240000000185f),
          new PlayNote(Notes.Fs5, 164.95271400000001f, 0.1621619999999666f),
          new PlayNote(Notes.Fs5, 165.11487599999998f, 0.3243240000000185f),
          new PlayNote(Notes.G5, 165.4392f, 0.16216199999999503f),
          new PlayNote(Notes.A5, 165.601362f, 0.4864860000000135f),
          new PlayNote(Notes.G5, 166.087848f, 0.32432399999999006f),
          new PlayNote(Notes.Fs5, 166.412172f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 166.574334f, 0.3243240000000185f),
          new PlayNote(Notes.D5, 166.898658f, 0.1621619999999666f),
          new PlayNote(Notes.Cs5, 167.06081999999998f, 0.3243240000000185f),
          new PlayNote(Notes.D5, 167.385144f, 0.16216199999999503f),
          new PlayNote(Notes.E5, 167.547306f, 0.8108100000000036f),
          new PlayNote(Notes.Fs5, 168.358116f, 0.16216199999999503f),
          new PlayNote(Notes.G5, 168.520278f, 0.3243240000000185f),
          new PlayNote(Notes.G5, 168.844602f, 0.1621619999999666f),
          new PlayNote(Notes.D5, 169.00676399999998f, 0.3243240000000185f),
          new PlayNote(Notes.D5, 169.331088f, 0.16216199999999503f),
          new PlayNote(Notes.B4, 169.49325f, 0.32432399999999006f),
          new PlayNote(Notes.B4, 169.81757399999998f, 0.16216200000002345f),
          new PlayNote(Notes.G5, 169.979736f, 0.32432399999999006f),
          new PlayNote(Notes.G5, 170.30406f, 0.16216200000002345f),
          new PlayNote(Notes.Fs5, 170.46622200000002f, 0.4864859999999851f),
          new PlayNote(Notes.E5, 170.952708f, 0.4864859999999851f),
          new PlayNote(Notes.D5, 171.439194f, 0.4864860000000135f),
          new PlayNote(Notes.Cs5, 171.92568f, 0.4864860000000135f),
          new PlayNote(Notes.B4, 172.412166f, 0.1621619999999666f),
          new PlayNote(Notes.Fs5, 237.925614f, 0.4864860000000135f),
          new PlayNote(Notes.D5, 238.4121f, 0.4864860000000135f),
          new PlayNote(Notes.B4, 238.89858600000002f, 0.4864859999999567f),
          new PlayNote(Notes.B4, 239.38507199999998f, 0.32432399999999006f),
          new PlayNote(Notes.Fs5, 239.70939599999997f, 0.16216200000002345f),
          new PlayNote(Notes.E5, 239.871558f, 0.4864860000000135f),
          new PlayNote(Notes.Cs5, 240.358044f, 0.4864860000000135f),
          new PlayNote(Notes.A4, 240.84453000000002f, 0.8108100000000036f),
          new PlayNote(Notes.Fs5, 241.65534000000002f, 0.1621619999999666f),
          new PlayNote(Notes.G5, 241.817502f, 0.32432399999999006f),
          new PlayNote(Notes.G5, 242.14182599999998f, 0.16216200000002345f),
          new PlayNote(Notes.G5, 242.303988f, 0.32432399999999006f),
          new PlayNote(Notes.G5, 242.628312f, 0.16216200000002345f),
          new PlayNote(Notes.G5, 242.79047400000002f, 0.32432399999999006f),
          new PlayNote(Notes.G5, 243.114798f, 0.1621619999999666f),
          new PlayNote(Notes.A5, 243.27695999999997f, 0.3243240000000469f),
          new PlayNote(Notes.G5, 243.60128400000002f, 0.1621619999999666f),
          new PlayNote(Notes.Fs5, 243.763446f, 0.32432399999999006f),
          new PlayNote(Notes.E5, 244.08776999999998f, 0.16216200000002345f),
          new PlayNote(Notes.D5, 244.249932f, 0.32432399999999006f),
          new PlayNote(Notes.E5, 244.574256f, 0.16216200000002345f),
          new PlayNote(Notes.Fs5, 244.73641800000001f, 0.6486479999999801f),
          new PlayNote(Notes.Fs5, 245.385066f, 0.16216200000002345f),
          new PlayNote(Notes.Fs5, 245.54722800000002f, 0.1621619999999666f),
          new PlayNote(Notes.Fs5, 245.70938999999998f, 0.32432399999999006f),
          new PlayNote(Notes.Fs5, 246.03371399999997f, 0.16216200000002345f),
          new PlayNote(Notes.Fs5, 246.195876f, 0.32432399999999006f),
          new PlayNote(Notes.G5, 246.5202f, 0.16216200000002345f),
          new PlayNote(Notes.A5, 246.682362f, 0.4864859999999567f),
          new PlayNote(Notes.G5, 247.16884799999997f, 0.3243240000000469f),
          new PlayNote(Notes.Fs5, 247.49317200000002f, 0.1621619999999666f),
          new PlayNote(Notes.E5, 247.65533399999998f, 0.32432399999999006f),
          new PlayNote(Notes.D5, 247.97965799999997f, 0.16216200000002345f),
          new PlayNote(Notes.Cs5, 248.14182f, 0.32432399999999006f),
          new PlayNote(Notes.D5, 248.46614399999999f, 0.16216200000002345f),
          new PlayNote(Notes.E5, 248.628306f, 0.8108100000000036f),
          new PlayNote(Notes.Fs5, 249.439116f, 0.1621619999999666f),
          new PlayNote(Notes.G5, 249.60127799999998f, 0.32432399999999006f),
          new PlayNote(Notes.G5, 249.92560199999997f, 0.16216200000002345f),
          new PlayNote(Notes.D5, 250.087764f, 0.32432399999999006f),
          new PlayNote(Notes.D5, 250.41208799999998f, 0.16216200000002345f),
          new PlayNote(Notes.B4, 250.57425f, 0.32432399999999006f),
          new PlayNote(Notes.B4, 250.898574f, 0.16216200000002345f),
          new PlayNote(Notes.G5, 251.06073600000002f, 0.32432399999999006f),
          new PlayNote(Notes.G5, 251.38506f, 0.1621619999999666f),
          new PlayNote(Notes.Fs5, 251.54722199999998f, 0.4864860000000135f),
          new PlayNote(Notes.E5, 252.033708f, 0.4864860000000135f),
          new PlayNote(Notes.D5, 252.520194f, 0.4864860000000135f),
          new PlayNote(Notes.Cs5, 253.00668000000002f, 0.4864859999999567f),
          new PlayNote(Notes.Fs5, 253.49316599999997f, 0.4864860000000135f),
          new PlayNote(Notes.D5, 253.979652f, 0.4864860000000135f),
          new PlayNote(Notes.B4, 254.466138f, 0.4864860000000135f),
          new PlayNote(Notes.B4, 254.95262400000001f, 0.32432399999999006f),
          new PlayNote(Notes.Fs5, 255.276948f, 0.1621619999999666f),
          new PlayNote(Notes.E5, 255.43910999999997f, 0.4864860000000135f),
          new PlayNote(Notes.Cs5, 255.92559599999998f, 0.4864860000000135f),
          new PlayNote(Notes.A4, 256.412082f, 0.8108100000000036f),
          new PlayNote(Notes.Fs5, 257.222892f, 0.1621619999999666f),
          new PlayNote(Notes.G5, 257.38505399999997f, 0.3243240000000469f),
          new PlayNote(Notes.G5, 257.709378f, 0.1621619999999666f),
          new PlayNote(Notes.G5, 257.87154f, 0.32432399999999006f),
          new PlayNote(Notes.G5, 258.195864f, 0.16216200000002345f),
          new PlayNote(Notes.G5, 258.358026f, 0.32432399999999006f),
          new PlayNote(Notes.G5, 258.68235f, 0.16216200000002345f),
          new PlayNote(Notes.A5, 258.844512f, 0.32432399999999006f),
          new PlayNote(Notes.G5, 259.168836f, 0.16216200000002345f),
          new PlayNote(Notes.Fs5, 259.330998f, 0.32432399999999006f),
          new PlayNote(Notes.E5, 259.655322f, 0.1621619999999666f),
          new PlayNote(Notes.D5, 259.817484f, 0.32432399999999006f),
          new PlayNote(Notes.E5, 260.14180799999997f, 0.16216200000002345f),
          new PlayNote(Notes.Fs5, 260.30397f, 0.6486479999999801f),
          new PlayNote(Notes.Fs5, 260.952618f, 0.16216200000002345f),
          new PlayNote(Notes.Fs5, 261.11478f, 0.16216200000002345f),
          new PlayNote(Notes.Fs5, 261.276942f, 0.32432399999999006f),
          new PlayNote(Notes.Fs5, 261.601266f, 0.1621619999999666f),
          new PlayNote(Notes.Fs5, 261.763428f, 0.3243240000000469f),
          new PlayNote(Notes.G5, 262.087752f, 0.1621619999999666f),
          new PlayNote(Notes.A5, 262.249914f, 0.4864860000000135f),
          new PlayNote(Notes.G5, 262.7364f, 0.32432399999999006f),
          new PlayNote(Notes.Fs5, 263.060724f, 0.16216200000002345f),
          new PlayNote(Notes.E5, 263.222886f, 0.32432399999999006f),
          new PlayNote(Notes.D5, 263.54721f, 0.1621619999999666f),
          new PlayNote(Notes.Cs5, 263.709372f, 0.3243240000000469f),
          new PlayNote(Notes.D5, 264.033696f, 0.1621619999999666f),
          new PlayNote(Notes.E5, 264.195858f, 0.8108100000000036f),
          new PlayNote(Notes.Fs5, 265.006668f, 0.16216200000002345f),
          new PlayNote(Notes.G5, 265.16883f, 0.32432399999999006f),
          new PlayNote(Notes.G5, 265.493154f, 0.1621619999999666f),
          new PlayNote(Notes.D5, 265.65531599999997f, 0.3243240000000469f),
          new PlayNote(Notes.D5, 265.97964f, 0.1621619999999666f),
          new PlayNote(Notes.B4, 266.141802f, 0.32432399999999006f),
          new PlayNote(Notes.B4, 266.466126f, 0.16216200000002345f),
          new PlayNote(Notes.G5, 266.628288f, 0.32432399999999006f),
          new PlayNote(Notes.G5, 266.952612f, 0.16216200000002345f),
          new PlayNote(Notes.Fs5, 267.114774f, 0.4864859999999567f),
          new PlayNote(Notes.E5, 267.60125999999997f, 0.4864860000000135f),
          new PlayNote(Notes.D5, 268.087746f, 0.4864860000000135f),
          new PlayNote(Notes.Cs5, 268.574232f, 0.4864860000000135f),
          new PlayNote(Notes.B4, 269.060718f, 0.1621619999999666f),
          new PlayNote(Notes.B5, 271.979634f, 0.3243240000000469f),
          new PlayNote(Notes.B5, 272.303958f, 0.32432399999999006f),
          new PlayNote(Notes.B5, 272.628282f, 0.1621619999999666f),

        }
        );
    }
}
