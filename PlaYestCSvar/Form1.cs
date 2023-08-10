using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaYestCSvar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static private List<Music> musicList = new List<Music>{
            new Music(){title ="물만난 물고기", artist="악뮤(akmu)", album="항해", year=2019, mood="청량"},
            new Music(){title ="200%", artist="악뮤(akmu)", album="Play", year=2014, mood="청량"},
            new Music(){title ="어떻게 이별까지 사랑하겠어 널사랑하는 거지", artist="악뮤(akmu)", album="항해", year=2019, mood="잔잔한"},
            new Music(){title ="낙하", artist="악뮤(akmu)", album="Next Episode", year=2020, mood="신나는"},
            new Music(){title ="오랜날오랜밤", artist="악뮤(akmu)", album="사춘기 하", year=2017, mood="잔잔한"},
            new Music(){title ="라일락", artist="아이유(IU)", album="Lilac", year=2021, mood="신나는"},
            new Music(){title ="하루끝", artist="아이유(IU)", album="스무살의 봄", year=2012, mood="청량"},
            new Music(){title ="아이와 나의 바다", artist="아이유(IU)", album="Lilac", year=2021, mood="잔잔한"},
            new Music(){title ="드라마", artist="아이유(IU)", album="조각집", year=2022, mood="잔잔한"},
            new Music(){title ="좋은날", artist="아이유(IU)", album="REAL", year=2010, mood="신나는"},
            new Music(){title ="매일 그대라서 행복하다", artist="세븐틴(seventeen)", album="Attacca", year=2021, mood="잔잔한"},
            new Music(){title ="아낀다", artist="세븐틴(seventeen)", album="17 CARAT", year=2015, mood="청량"},
            new Music(){title ="어른아이", artist="세븐틴(seventeen)", album="헹가래", year=2020, mood="청량"},
            new Music(){title ="HOT", artist="세븐틴(seventeen)", album="Face The Sun", year=2022, mood="신나는"},
            new Music(){title ="손오공", artist="세븐틴(seventeen)", album="FML", year=2023, mood="신나는"},
            new Music(){title ="리얼리티", artist="악뮤(akmu)", album="사춘기 하", year=2017, mood="신나는"},
            new Music(){title ="Stupid love song", artist="악뮤(akmu)", album="Next Episode", year=2020, mood="잔잔한"},
            new Music(){title ="사람들이 움직이는게", artist="악뮤(akmu)", album="사춘기 상", year=2016, mood="신나는"},
            new Music(){title ="겨울잠", artist="아이유(IU)", album="조각집", year=2022, mood="잔잔한"},
            new Music(){title ="어쩌나", artist="악뮤(akmu)", album="you make my day ", year=2018, mood="청량"},
        };

        private void button1_Click(object sender, EventArgs e)
        {
            musicBindingSource.DataSource = musicList;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
