# Introduction #


## Source code before integrating delegation ##
```c#

1. Video.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace EventDelegate
{
   public class Video
    {
        public string Title { get; set;  }
    }
}
```


```c#

2. VideoEncoder.cs

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventDelegate
{
    public class VideoEncoder
    {
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
        }
    }
}
```

```c#

3. Program.cs

using System;

namespace EventDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video1" };
            var videoEncoder = new VideoEncoder();

            videoEncoder.Encode(video);
        }
    }
}
```

## Source code after integrating delegation ##

```c#

4. Video.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace EventDelegate
{
   public class Video
    {
        public string Title { get; set;  }
    }
}
```


```c#

5. VideoEncoder.cs

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventDelegate
{

    public class VideoEncoder
    {
        // 1-Define a delegate
        // 2-Define an event based on that delegate
        // 3-Raise the event


        // 1-Define a delegate
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        //2-Define an event based on that delegate
        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
        }

        // 3-raise the event; dot net convention- method must be onFunctionName, void, virtual
        protected virtual void onVideoEncoded()
        {
            //notify all the subscribers
            // check if any subscriber to the event
            if (VideoEncoded != null)
                //event defined in step 2 but containing signature of delegate of step 1
                VideoEncoded(this, EventArgs.Empty);
        }



    }
}
```

```c#

6. Program.cs

using System;

namespace EventDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video1" };
            var videoEncoder = new VideoEncoder(); //publisher

            var mailService = new MailService(); //subscriber


            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;



            videoEncoder.Encode(video);
            
        }
    }

    //Creating a subscriber
    public class MailService
    {
        //Define the method that conforms the signature of delegate defined inside VideoEncoder.cs  - that means must be void and two paramters
        
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("Mailservice sending an email.....");
        }

    }
}
```

# References # 
- https://www.youtube.com/watch?v=jQgwEsJISy0
- https://www.tutorialsteacher.com/csharp/csharp-event


## More references ##
- https://stackoverflow.com/questions/44201675/null-reference-exception-when-raising-event-in-c-sharp
- https://stackoverflow.com/questions/5766979/nullreferenceexception-when-triggering-event
- https://stackoverflow.com/questions/6835766/why-can-a-net-delegate-not-be-declared-static
- https://www.c-sharpcorner.com/UploadFile/puranindia/C-Sharp-net-delegates-and-events/
