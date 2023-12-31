
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetsujouNoSpectrum : SongScript
{
    public override Song GetSong()
    {
        return new Song(
        2,
        18,
        new List<PlayNote> 
        {
          new PlayNote(Notes.As5, 0.75f, 0.09375f),
          new PlayNote(Notes.G6, 0.84375f, 0.09375f),
          new PlayNote(Notes.Fs6, 0.9375f, 0.09375f),
          new PlayNote(Notes.E6, 1.03125f, 0.09375f),
          new PlayNote(Notes.Fs6, 1.125f, 0.09375f),
          new PlayNote(Notes.E6, 1.21875f, 0.09375f),
          new PlayNote(Notes.D6, 1.3125f, 0.09375f),
          new PlayNote(Notes.Cs6, 1.40625f, 0.09375f),
          new PlayNote(Notes.B5, 1.5f, 0.375f),
          new PlayNote(Notes.Cs6, 1.875f, 0.375f),
          new PlayNote(Notes.D6, 2.25f, 0.375f),
          new PlayNote(Notes.E6, 2.625f, 0.375f),
          new PlayNote(Notes.Fs6, 3.0f, 0.75f),
          new PlayNote(Notes.Fs6, 3.75f, 0.375f),
          new PlayNote(Notes.B6, 4.125f, 0.375f),
          new PlayNote(Notes.A6, 4.5f, 0.375f),
          new PlayNote(Notes.B6, 4.875f, 0.375f),
          new PlayNote(Notes.E6, 5.25f, 0.375f),
          new PlayNote(Notes.G6, 5.625f, 0.375f),
          new PlayNote(Notes.Fs6, 6.0f, 0.75f),
          new PlayNote(Notes.E5, 7.125f, 0.1875f),
          new PlayNote(Notes.Fs5, 7.3125f, 0.1875f),
          new PlayNote(Notes.G5, 7.5f, 0.1875f),
          new PlayNote(Notes.Fs5, 7.6875f, 0.1875f),
          new PlayNote(Notes.E5, 7.875f, 0.1875f),
          new PlayNote(Notes.D5, 8.0625f, 0.1875f),
          new PlayNote(Notes.Cs5, 8.25f, 0.375f),
          new PlayNote(Notes.D5, 8.625f, 0.1875f),
          new PlayNote(Notes.E5, 8.8125f, 0.1875f),
          new PlayNote(Notes.Fs5, 9.0f, 0.1875f),
          new PlayNote(Notes.E5, 9.1875f, 0.1875f),
          new PlayNote(Notes.D5, 9.375f, 0.1875f),
          new PlayNote(Notes.Cs5, 9.5625f, 0.1875f),
          new PlayNote(Notes.Gs4, 9.75f, 0.375f),
          new PlayNote(Notes.B4, 10.125f, 0.1875f),
          new PlayNote(Notes.A4, 10.3125f, 0.1875f),
          new PlayNote(Notes.G4, 10.5f, 0.375f),
          new PlayNote(Notes.A4, 10.875f, 0.375f),
          new PlayNote(Notes.B4, 11.25f, 0.375f),
          new PlayNote(Notes.G5, 11.625f, 0.375f),
          new PlayNote(Notes.Fs5, 12.0f, 0.375f),
          new PlayNote(Notes.E5, 12.375f, 0.375f),
          new PlayNote(Notes.D5, 12.75f, 0.375f),
          new PlayNote(Notes.Cs5, 13.125f, 0.375f),
          new PlayNote(Notes.B4, 13.5f, 0.375f),
          new PlayNote(Notes.Cs5, 13.875f, 0.375f),
          new PlayNote(Notes.D5, 14.25f, 0.375f),
          new PlayNote(Notes.E5, 14.625f, 0.375f),
          new PlayNote(Notes.Fs5, 15.0f, 0.75f),
          new PlayNote(Notes.Fs5, 15.75f, 0.375f),
          new PlayNote(Notes.B5, 16.125f, 0.375f),
          new PlayNote(Notes.E5, 16.5f, 0.375f),
          new PlayNote(Notes.E5, 16.875f, 0.375f),
          new PlayNote(Notes.E5, 17.25f, 0.375f),
          new PlayNote(Notes.G5, 17.625f, 0.375f),
          new PlayNote(Notes.Fs5, 18.0f, 1.125f),
          new PlayNote(Notes.E5, 19.125f, 0.1875f),
          new PlayNote(Notes.Fs5, 19.3125f, 0.1875f),
          new PlayNote(Notes.G5, 19.5f, 0.1875f),
          new PlayNote(Notes.Fs5, 19.6875f, 0.1875f),
          new PlayNote(Notes.E5, 19.875f, 0.1875f),
          new PlayNote(Notes.D5, 20.0625f, 0.1875f),
          new PlayNote(Notes.Cs5, 20.25f, 0.375f),
          new PlayNote(Notes.D5, 20.625f, 0.1875f),
          new PlayNote(Notes.E5, 20.8125f, 0.1875f),
          new PlayNote(Notes.Fs5, 21.0f, 0.1875f),
          new PlayNote(Notes.E5, 21.1875f, 0.1875f),
          new PlayNote(Notes.D5, 21.375f, 0.1875f),
          new PlayNote(Notes.Cs5, 21.5625f, 0.1875f),
          new PlayNote(Notes.B4, 21.75f, 0.375f),
          new PlayNote(Notes.B4, 22.125f, 0.1875f),
          new PlayNote(Notes.A4, 22.3125f, 0.1875f),
          new PlayNote(Notes.G4, 22.5f, 0.375f),
          new PlayNote(Notes.A4, 22.875f, 0.375f),
          new PlayNote(Notes.B4, 23.25f, 0.375f),
          new PlayNote(Notes.G5, 23.625f, 0.375f),
          new PlayNote(Notes.Fs5, 24.0f, 0.5625f),
          new PlayNote(Notes.As5, 24.75f, 0.375f),
          new PlayNote(Notes.Fs5, 25.125f, 0.1875f),
          new PlayNote(Notes.B5, 25.3125f, 0.1875f),
          new PlayNote(Notes.Fs4, 25.5f, 0.375f),
          new PlayNote(Notes.Fs4, 25.875f, 0.375f),
          new PlayNote(Notes.B4, 26.25f, 0.1875f),
          new PlayNote(Notes.Cs5, 26.4375f, 0.1875f),
          new PlayNote(Notes.G4, 26.8125f, 0.5625f),
          new PlayNote(Notes.E5, 27.375f, 0.375f),
          new PlayNote(Notes.Cs5, 27.75f, 0.1875f),
          new PlayNote(Notes.D5, 27.9375f, 0.1875f),
          new PlayNote(Notes.G4, 28.3125f, 0.5625f),
          new PlayNote(Notes.Fs5, 28.875f, 0.375f),
          new PlayNote(Notes.D5, 29.25f, 0.1875f),
          new PlayNote(Notes.E5, 29.4375f, 0.1875f),
          new PlayNote(Notes.Fs5, 29.8125f, 0.1875f),
          new PlayNote(Notes.G5, 30.1875f, 0.1875f),
          new PlayNote(Notes.As5, 30.5625f, 0.1875f),
          new PlayNote(Notes.Cs6, 30.9375f, 0.1875f),
          new PlayNote(Notes.E5, 31.125f, 0.1875f),
          new PlayNote(Notes.Fs5, 31.3125f, 0.375f),
          new PlayNote(Notes.Fs5, 31.6875f, 0.1875f),
          new PlayNote(Notes.E5, 31.875f, 0.1875f),
          new PlayNote(Notes.E5, 32.0625f, 0.1875f),
          new PlayNote(Notes.D5, 32.25f, 0.1875f),
          new PlayNote(Notes.D5, 32.4375f, 0.1875f),
          new PlayNote(Notes.Cs5, 32.625f, 0.1875f),
          new PlayNote(Notes.D5, 32.8125f, 0.375f),
          new PlayNote(Notes.D5, 33.1875f, 0.1875f),
          new PlayNote(Notes.Cs5, 33.375f, 0.1875f),
          new PlayNote(Notes.Cs5, 33.5625f, 0.1875f),
          new PlayNote(Notes.B4, 33.75f, 0.1875f),
          new PlayNote(Notes.B4, 33.9375f, 0.1875f),
          new PlayNote(Notes.A4, 34.125f, 0.1875f),
          new PlayNote(Notes.A4, 34.3125f, 0.1875f),
          new PlayNote(Notes.B4, 34.5f, 0.5625f),
          new PlayNote(Notes.Fs5, 35.0625f, 0.1875f),
          new PlayNote(Notes.Fs5, 35.25f, 0.1875f),
          new PlayNote(Notes.B4, 35.4375f, 0.1875f),
          new PlayNote(Notes.Fs5, 35.625f, 0.1875f),
          new PlayNote(Notes.B5, 35.8125f, 0.1875f),
          new PlayNote(Notes.B4, 36.0f, 0.1875f),
          new PlayNote(Notes.Fs5, 36.1875f, 0.1875f),
          new PlayNote(Notes.Cs6, 36.375f, 0.1875f),
          new PlayNote(Notes.B4, 36.5625f, 0.1875f),
          new PlayNote(Notes.B5, 36.75f, 0.1875f),
          new PlayNote(Notes.D5, 36.9375f, 0.1875f),
          new PlayNote(Notes.E5, 37.125f, 0.1875f),
          new PlayNote(Notes.Fs5, 37.3125f, 0.375f),
          new PlayNote(Notes.Fs5, 37.6875f, 0.1875f),
          new PlayNote(Notes.E5, 37.875f, 0.1875f),
          new PlayNote(Notes.E5, 38.0625f, 0.1875f),
          new PlayNote(Notes.D5, 38.25f, 0.1875f),
          new PlayNote(Notes.D5, 38.4375f, 0.1875f),
          new PlayNote(Notes.Cs5, 38.625f, 0.1875f),
          new PlayNote(Notes.D5, 38.8125f, 0.375f),
          new PlayNote(Notes.D5, 39.1875f, 0.1875f),
          new PlayNote(Notes.Cs5, 39.375f, 0.1875f),
          new PlayNote(Notes.Cs5, 39.5625f, 0.1875f),
          new PlayNote(Notes.B4, 39.75f, 0.1875f),
          new PlayNote(Notes.B4, 39.9375f, 0.1875f),
          new PlayNote(Notes.A4, 40.125f, 0.1875f),
          new PlayNote(Notes.A4, 40.3125f, 0.1875f),
          new PlayNote(Notes.B4, 40.5f, 0.5625f),
          new PlayNote(Notes.Fs5, 41.0625f, 0.1875f),
          new PlayNote(Notes.Fs5, 41.25f, 0.1875f),
          new PlayNote(Notes.B4, 41.4375f, 0.1875f),
          new PlayNote(Notes.Fs5, 41.625f, 0.1875f),
          new PlayNote(Notes.B5, 41.8125f, 0.1875f),
          new PlayNote(Notes.Fs5, 42.0f, 0.1875f),
          new PlayNote(Notes.B4, 42.1875f, 0.1875f),
          new PlayNote(Notes.D5, 42.375f, 0.1875f),
          new PlayNote(Notes.A4, 42.5625f, 0.1875f),
          new PlayNote(Notes.B4, 42.75f, 0.1875f),
          new PlayNote(Notes.A4, 42.9375f, 0.1875f),
          new PlayNote(Notes.B4, 43.125f, 0.1875f),
          new PlayNote(Notes.Cs5, 43.3125f, 0.1875f),
          new PlayNote(Notes.Fs4, 43.5f, 0.5625f),
          new PlayNote(Notes.Fs4, 44.0625f, 0.1875f),
          new PlayNote(Notes.Cs5, 44.25f, 0.1875f),
          new PlayNote(Notes.D5, 44.4375f, 0.1875f),
          new PlayNote(Notes.E5, 44.625f, 0.1875f),
          new PlayNote(Notes.A5, 44.8125f, 0.1875f),
          new PlayNote(Notes.Fs5, 45.0f, 1.125f),
          new PlayNote(Notes.B4, 46.125f, 0.1875f),
          new PlayNote(Notes.A4, 46.3125f, 0.1875f),
          new PlayNote(Notes.G4, 46.5f, 0.375f),
          new PlayNote(Notes.G4, 46.875f, 0.375f),
          new PlayNote(Notes.As4, 47.25f, 0.1875f),
          new PlayNote(Notes.B4, 47.4375f, 0.1875f),
          new PlayNote(Notes.Cs5, 47.625f, 0.1875f),
          new PlayNote(Notes.G5, 47.8125f, 0.1875f),
          new PlayNote(Notes.Fs5, 48.0f, 0.375f),
          new PlayNote(Notes.E5, 48.375f, 0.375f),
          new PlayNote(Notes.D5, 48.75f, 0.375f),
          new PlayNote(Notes.D5, 49.125f, 0.1875f),
          new PlayNote(Notes.Cs5, 49.3125f, 0.1875f),
          new PlayNote(Notes.Fs4, 49.5f, 0.375f),
          new PlayNote(Notes.Fs4, 49.875f, 0.1875f),
          new PlayNote(Notes.Fs4, 50.0625f, 0.1875f),
          new PlayNote(Notes.Cs5, 50.25f, 0.1875f),
          new PlayNote(Notes.D5, 50.4375f, 0.1875f),
          new PlayNote(Notes.E5, 50.625f, 0.1875f),
          new PlayNote(Notes.A5, 50.8125f, 0.1875f),
          new PlayNote(Notes.Fs5, 51.0f, 1.125f),
          new PlayNote(Notes.D5, 52.125f, 0.1875f),
          new PlayNote(Notes.E5, 52.3125f, 0.1875f),
          new PlayNote(Notes.Fs5, 52.5f, 0.375f),
          new PlayNote(Notes.B4, 52.875f, 0.375f),
          new PlayNote(Notes.D5, 53.25f, 0.375f),
          new PlayNote(Notes.E5, 53.625f, 0.1875f),
          new PlayNote(Notes.Fs5, 53.8125f, 0.75f),
          new PlayNote(Notes.E5, 54.5625f, 0.1875f),
          new PlayNote(Notes.E5, 54.75f, 0.375f),
          new PlayNote(Notes.D5, 55.125f, 0.1875f),
          new PlayNote(Notes.Fs5, 55.3125f, 0.1875f),
          new PlayNote(Notes.As4, 55.5f, 0.375f),
          new PlayNote(Notes.As4, 55.875f, 0.1875f),
          new PlayNote(Notes.A4, 56.0625f, 0.1875f),
          new PlayNote(Notes.As4, 56.25f, 0.1875f),
          new PlayNote(Notes.B4, 56.4375f, 0.1875f),
          new PlayNote(Notes.Cs5, 56.625f, 0.1875f),
          new PlayNote(Notes.E5, 56.8125f, 0.1875f),
          new PlayNote(Notes.Fs5, 57.0f, 0.09375f),
          new PlayNote(Notes.Fs5, 57.09375f, 0.1875f),
          new PlayNote(Notes.Fs5, 57.5625f, 0.09375f),
          new PlayNote(Notes.Fs5, 57.65625f, 0.1875f),
          new PlayNote(Notes.G6, 57.84375f, 0.09375f),
          new PlayNote(Notes.Fs6, 57.9375f, 0.09375f),
          new PlayNote(Notes.E6, 58.03125f, 0.09375f),
          new PlayNote(Notes.Fs6, 58.125f, 0.09375f),
          new PlayNote(Notes.E6, 58.21875f, 0.09375f),
          new PlayNote(Notes.D6, 58.3125f, 0.09375f),
          new PlayNote(Notes.Cs6, 58.40625f, 0.09375f),
          new PlayNote(Notes.B5, 58.5f, 0.375f),
          new PlayNote(Notes.Cs5, 58.875f, 0.375f),
          new PlayNote(Notes.D5, 59.25f, 0.375f),
          new PlayNote(Notes.E5, 59.625f, 0.375f),
          new PlayNote(Notes.Fs5, 60.0f, 0.75f),
          new PlayNote(Notes.Fs5, 60.75f, 0.375f),
          new PlayNote(Notes.B5, 61.125f, 0.375f),
          new PlayNote(Notes.E5, 61.5f, 0.375f),
          new PlayNote(Notes.E5, 61.875f, 0.375f),
          new PlayNote(Notes.E5, 62.25f, 0.375f),
          new PlayNote(Notes.G5, 62.625f, 0.375f),
          new PlayNote(Notes.Fs5, 63.0f, 1.125f),
          new PlayNote(Notes.E5, 64.125f, 0.1875f),
          new PlayNote(Notes.Fs5, 64.3125f, 0.1875f),
          new PlayNote(Notes.G5, 64.5f, 0.1875f),
          new PlayNote(Notes.Fs5, 64.6875f, 0.1875f),
          new PlayNote(Notes.E5, 64.875f, 0.1875f),
          new PlayNote(Notes.D5, 65.0625f, 0.1875f),
          new PlayNote(Notes.Cs5, 65.25f, 0.375f),
          new PlayNote(Notes.D5, 65.625f, 0.1875f),
          new PlayNote(Notes.E5, 65.8125f, 0.1875f),
          new PlayNote(Notes.Fs5, 66.0f, 0.1875f),
          new PlayNote(Notes.E5, 66.1875f, 0.1875f),
          new PlayNote(Notes.D5, 66.375f, 0.1875f),
          new PlayNote(Notes.Cs5, 66.5625f, 0.1875f),
          new PlayNote(Notes.B4, 66.75f, 0.375f),
          new PlayNote(Notes.B4, 67.125f, 0.1875f),
          new PlayNote(Notes.A4, 67.3125f, 0.1875f),
          new PlayNote(Notes.G4, 67.5f, 0.375f),
          new PlayNote(Notes.A4, 67.875f, 0.375f),
          new PlayNote(Notes.B4, 68.25f, 0.375f),
          new PlayNote(Notes.G5, 68.625f, 0.375f),
          new PlayNote(Notes.Fs5, 69.0f, 0.375f),
          new PlayNote(Notes.E5, 69.375f, 0.375f),
          new PlayNote(Notes.D5, 69.75f, 0.375f),
          new PlayNote(Notes.Cs5, 70.125f, 0.375f),
          new PlayNote(Notes.B4, 70.5f, 0.375f),
          new PlayNote(Notes.Cs5, 70.875f, 0.375f),
          new PlayNote(Notes.D5, 71.25f, 0.375f),
          new PlayNote(Notes.E5, 71.625f, 0.375f),
          new PlayNote(Notes.Fs5, 72.0f, 0.75f),
          new PlayNote(Notes.Fs5, 72.75f, 0.375f),
          new PlayNote(Notes.B5, 73.125f, 0.375f),
          new PlayNote(Notes.E5, 73.5f, 0.375f),
          new PlayNote(Notes.E5, 73.875f, 0.375f),
          new PlayNote(Notes.E5, 74.25f, 0.375f),
          new PlayNote(Notes.G5, 74.625f, 0.375f),
          new PlayNote(Notes.Fs5, 75.0f, 1.125f),
          new PlayNote(Notes.E5, 76.125f, 0.1875f),
          new PlayNote(Notes.Fs5, 76.3125f, 0.1875f),
          new PlayNote(Notes.G5, 76.5f, 0.1875f),
          new PlayNote(Notes.Fs5, 76.6875f, 0.1875f),
          new PlayNote(Notes.E5, 76.875f, 0.1875f),
          new PlayNote(Notes.D5, 77.0625f, 0.1875f),
          new PlayNote(Notes.Cs5, 77.25f, 0.375f),
          new PlayNote(Notes.D5, 77.625f, 0.1875f),
          new PlayNote(Notes.E5, 77.8125f, 0.1875f),
          new PlayNote(Notes.Fs5, 78.0f, 0.1875f),
          new PlayNote(Notes.E5, 78.1875f, 0.1875f),
          new PlayNote(Notes.D5, 78.375f, 0.1875f),
          new PlayNote(Notes.Cs5, 78.5625f, 0.1875f),
          new PlayNote(Notes.B4, 78.75f, 0.375f),
          new PlayNote(Notes.B4, 79.125f, 0.1875f),
          new PlayNote(Notes.A4, 79.3125f, 0.1875f),
          new PlayNote(Notes.G4, 79.5f, 0.375f),
          new PlayNote(Notes.A4, 79.875f, 0.375f),
          new PlayNote(Notes.B4, 80.25f, 0.375f),
          new PlayNote(Notes.G5, 80.625f, 0.375f),
          new PlayNote(Notes.Fs5, 81.0f, 0.5625f),
          new PlayNote(Notes.As5, 81.75f, 0.375f),
          new PlayNote(Notes.Fs5, 82.125f, 0.1875f),
          new PlayNote(Notes.B5, 82.3125f, 0.1875f),
          new PlayNote(Notes.Fs4, 82.5f, 0.375f),
          new PlayNote(Notes.Fs4, 82.875f, 0.375f),
          new PlayNote(Notes.B4, 83.25f, 0.1875f),
          new PlayNote(Notes.Cs5, 83.4375f, 0.1875f),
          new PlayNote(Notes.G4, 83.8125f, 0.5625f),
          new PlayNote(Notes.E5, 84.375f, 0.375f),
          new PlayNote(Notes.Cs5, 84.75f, 0.1875f),
          new PlayNote(Notes.D5, 84.9375f, 0.1875f),
          new PlayNote(Notes.G4, 85.3125f, 0.5625f),
          new PlayNote(Notes.Fs5, 85.875f, 0.375f),
          new PlayNote(Notes.D5, 86.25f, 0.1875f),
          new PlayNote(Notes.E5, 86.4375f, 0.1875f),
          new PlayNote(Notes.Fs5, 86.8125f, 0.1875f),
          new PlayNote(Notes.G5, 87.1875f, 0.1875f),
          new PlayNote(Notes.As5, 87.5625f, 0.1875f),
          new PlayNote(Notes.Cs6, 87.9375f, 0.5625f),
          new PlayNote(Notes.B5, 88.5f, 1.5f),

        },
        0.5f
        );
    }
}
