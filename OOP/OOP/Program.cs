using System;
using System.Collections;

namespace OOP_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Human Bruno = new Human("21", "Bruno");
            Console.WriteLine(Bruno.getAge());
            Bruno.Speak();

            Member mem = new Member(102);
            mem.getID();
            ArrayList myList = new ArrayList();

            //myList.Add(mem);
            myList.Add(Bruno);

            foreach(var obj in myList)
            {
                var myObj = obj as Human;
                Console.WriteLine(myObj.getAge()); 
            }

            Console.WriteLine("=============");

            Posts post = new Posts("Thanks guys!!", "Brunodev09", true);
            ImagePosts imagePosts = new ImagePosts("Image.png", "Brunodev09", "https://google.com.br", true);
            VideoPosts video = new VideoPosts("video.mp3", "Brunodev09", "https://youtube.com", true, 12);
            video.Play();

            Console.WriteLine(post.ToString());
            Console.WriteLine(imagePosts.ToString());

            Console.ReadKey();
            video.Stop();
        } 
        //destructor will be called here, when we're out of scope, or when the object is deleted
    }
}