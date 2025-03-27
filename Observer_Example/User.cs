using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Example
{
    public class User
    {
// ایجاد پخش‌کننده فیلم
        MoviePlayer moviePlayer = new MoviePlayer();

        // ایجاد Observerها (ویدیو، صدا، زیرنویس)
        Video video = new Video();
        Audio audio = new Audio();
        Subtitles subtitles = new Subtitles();

        // ثبت Observerها در پخش‌کننده فیلم
        moviePlayer.AddObserver(video);
        moviePlayer.AddObserver(audio);
        moviePlayer.AddObserver(subtitles);

        // پخش فیلم
        moviePlayer.PlayMovie();
        
    }
}
