using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowApp
{
    class Post
    {
        private int _score;

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; private set; }
        public int Score
        {
            get
            {
                return _score;
            }
        }

        public Post()
        {
            Date = DateTime.Now;
            _score = 0;
        }

        public void Upvote()
        {
            _score++;
        }

        public void Downvote()
        {
            _score--;
        }

    }
}
