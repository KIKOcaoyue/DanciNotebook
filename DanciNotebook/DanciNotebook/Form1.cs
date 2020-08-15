using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DanciNotebook
{
    public partial class DanciNotebook : Form
    {
        public class Word
        {
            private string word;
            private string translate;
            private string example;
            private int    grade;

            public Word(){ }
            public Word(string word, string translate, string example, int grade)
            {
                this.word = word;
                this.translate = translate;
                this.example = example;
                this.grade = grade;
            }
            public void setWord(string word)
            {
                this.word = word;
            }
            public void setTranslate(string translate)
            {
                this.translate = translate;
            }
            public void setExample(string example)
            {
                this.example = example;
            }
            public void setGrade(int grade)
            {
                this.grade = grade;
            }
            
            public string getWord()
            {
                return this.word;
            }
            public string getTranslate()
            {
                return this.translate;
            }
            public string getExample()
            {
                return this.example;
            }
            public int getGrade()
            {
                return this.grade;
            }
        }

        List<Word> words = new List<Word>();
        List<Word> wordlist = new List<Word>();
        int now = 0;

        public void shuffe()
        {
            Random rd = new Random();
            while(words.Count > 0)
            {
                int selector = rd.Next(0, words.Count);
                wordlist.Add(words[selector]);
                words.RemoveAt(selector);
            }
            for(int i=0;i<wordlist.Count;i++)
            {
                Console.WriteLine(wordlist[i].getWord());
            }
        }

        public void displayword(int now)
        {
            word.Text = wordlist[now].getWord();
            grade.Text = wordlist[now].getGrade().ToString();
        }

        public void displaytranslate(int now)
        {
            translate.Text = wordlist[now].getTranslate();
            example.Text = wordlist[now].getExample();
        }

        public int findWord(string val)
        {
            for(int i=0;i<wordlist.Count;i++)
            {
                if (wordlist[i].getWord().Equals(val))
                {
                    return i;
                }
            }
            return -1;
        }
        public DanciNotebook()
        {
            InitializeComponent();
            try
            {
                using (StreamReader srd = new StreamReader("dancidata.txt"))
                {
                    int cnt = 0;
                    string line;
                    Word word = new Word();
                    while ((line = srd.ReadLine()) != null)
                    {
                        cnt++;
                        if(cnt%4==1)
                        {
                            word.setWord(line);
                        }
                        else if(cnt%4==2)
                        {
                            word.setTranslate(line);
                        }
                        else if(cnt%4==3)
                        {
                            word.setExample(line);
                        }
                        else if(cnt%4==0)
                        {
                            word.setGrade(int.Parse(line));
                        }
                        if (cnt == 4)
                        {
                            cnt = 0;
                            words.Add(word);
                            word = new Word();
                        }
                    }
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception);
            }
            shuffe();
            if(wordlist.Count>0)
            {
                displayword(now);
            }
            else
            {
                word.Text = "还没有单词";
            }
        }

        private void knownbtn_Click(object sender, EventArgs e)
        {
            int now = findWord(word.Text);
            int nowgrade = wordlist[now].getGrade();
            wordlist[now].setGrade(--nowgrade);
            if(nowgrade==0)
            {
                wordlist.RemoveAt(now);
                displayword(now);
                translate.Text = "遮挡住了";
                example.Text = "遮挡住了";
            }
            else
            {
                if(now<wordlist.Count-1)
                {
                    displayword(now+1);
                    translate.Text = "遮挡住了";
                    example.Text = "遮挡住了";
                }
            }
        }

        private void unknownbtn_Click(object sender, EventArgs e)
        {
            int now = findWord(word.Text);
            int nowgrade = wordlist[now].getGrade();
            wordlist[now].setGrade(++nowgrade);
            if (now < wordlist.Count-1)
            {
                displayword(now+1);
                translate.Text = "遮挡住了";
                example.Text = "遮挡住了";
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Word neword = new Word(newword.Text, newtranslate.Text, newexample.Text, 5);
            wordlist.Add(neword);
            newword.Text = "";
            newtranslate.Text = "";
            newexample.Text = "";
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            int now = findWord(word.Text);
            displaytranslate(now);
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("dancidata.txt", string.Empty);
            using (StreamWriter sw = new StreamWriter("dancidata.txt"))
            {
                for(int i=0;i<wordlist.Count;i++)
                {
                    sw.WriteLine(wordlist[i].getWord());
                    sw.WriteLine(wordlist[i].getTranslate());
                    sw.WriteLine(wordlist[i].getExample());
                    sw.WriteLine(wordlist[i].getGrade().ToString());
                }
            }
        }
    }
}
