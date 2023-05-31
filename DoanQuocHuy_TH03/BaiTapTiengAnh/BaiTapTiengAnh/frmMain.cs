using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace BaiTapTiengAnh
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void baiDienTu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = (sender as ToolStripMenuItem).ToString();
            string b = name.Substring(name.Length - 1);
            int count = Convert.ToInt32(b);
            DataClick.check = count - 1;
            frmDienTu frm = new frmDienTu();
            frm.ShowDialog();
            

        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            //baitap1
            BaiTapDienTu bt1 = new BaiTapDienTu();
            bt1.Debai = "It can take a long time to become successful in your chosen field, " +
"however talented you are. One thing you have to be (1) _______ of " +
"is that you will face criticism along the way. The world is (2) _______ of " +
 "people who would rather say something negative than positive. " +
"If you’ve made up your (3) _______ to achieve a certain goal, " +
"such as writing a novel, (4) _______ the negative criticism of others " +
"prevent you from reaching your target, and let the constructive criticism " +
"have a positive effect on your work. If someone says you’re totally " +
"in the (5) _______ of talent, ignore them. That’s negative criticism. " +
"If (6) _______ , someone advises you to revise your work and " +
"gives you a good reason for doing so, you should consider their suggestions carefully." +
" There are many film stars (7) _______ were once out of work . " +
"There are many famous novelists who made a complete mess of their first novel – or who didn’t," +
" but had to keep on approaching hundreds of publishers before they could get it (8) _______ . " +
"Being successful does depend on luck," +
" to a (9) _______ extent. But things are more likely to (10) _______ well if you persevere and stay positive.";
            bt1.Dapan = "It can take a long time to become successful in your chosen field, " +
"however talented you are. One thing you have to be (1) aware of " +
"is that you will face criticism along the way. The world is (2) full of " +
 "people who would rather say something negative than positive. " +
"If you’ve made up your (3) mind to achieve a certain goal, " +
"such as writing a novel, (4) don’t let the negative criticism of others " +
"prevent you from reaching your target, and let the constructive criticism " +
"have a positive effect on your work. If someone says you’re totally " +
"in the (5) lack of talent, ignore them. That’s negative criticism. " +
"If (6) however, someone advises you to revise your work and " +
"gives you a good reason for doing so, you should consider their suggestions carefully." +
" There are many film stars (7) who were once out of work . " +
"There are many famous novelists who made a complete mess of their first novel – or who didn’t," +
" but had to keep on approaching hundreds of publishers before they could get it (8) published. " +
"Being successful does depend on luck," +
" to a (9) certain extent. But things are more likely to (10) turn out well if you persevere and stay positive.";
            List<string> lists1 = new List<string>();
            lists1.Add("aware");
            lists1.Add("full");
            lists1.Add("mind");
            lists1.Add("don’t let");
            lists1.Add("lack");
            lists1.Add("however");
            lists1.Add("who");
            lists1.Add("published");
            lists1.Add("certain");
            lists1.Add("turn out");
            bt1.Dapantungcau = lists1;
            StaticData.bt.Add(bt1);
            //baitap2
            BaiTapDienTu bt2 = new BaiTapDienTu();
            bt2.Debai = "Today, the distinction between the professional and the " +
                "(1) _______ is purely a matter ofsporting success." +
                " Most (2) _______ start their career by winning competitions for non -professionals " +
                "before deciding to (3) _______ themselves to their chosen sport." +
                " However,for a long time, it used to be believed that getting paid for a sporting " +
                "(4) _______ destroyed the ancient Olympic (5) _______ of people simply trying to do theirbest " +
                "for the love of the sport.In fact, even (6) ________ in ancient Olympic (7) _______ were able " +
                "to make largeamounts of money from winning. At the games themselves, only a laurel wreath was " +
                "(8) _______ to the winner, but back in his (9) _______ town, he could become very rich" +
                ".During most of the 20th century, professionals were (10) _______ from entering theOlympics.";
            bt2.Dapan = "Today, the distinction between the professional and the " +
                "(1) amateur is purely a matter ofsporting success." +
                " Most (2) athletes start their career by winning competitions for non -professionals " +
                "before deciding to (3) devote themselves to their chosen sport." +
                " However,for a long time, it used to be believed that getting paid for a sporting " +
                "(4) performance destroyed the ancient Olympic (5) ideal of people simply trying to do theirbest " +
                "for the love of the sport.In fact, even (6) participants in ancient Olympic (7) events were able " +
                "to make largeamounts of money from winning. At the games themselves, only a laurel wreath was " +
                "(8) awarded to the winner, but back in his (9) home town, he could become very rich" +
                ".During most of the 20th century, professionals were (10) disallowed from entering theOlympics.";
            List<string> lists2 = new List<string>();
            lists2.Add("amateur");
            lists2.Add("athletes");
            lists2.Add("devote");
            lists2.Add("performance");
            lists2.Add("ideal");
            lists2.Add("participants");
            lists2.Add("events");
            lists2.Add("awarded");
            lists2.Add("home");
            lists2.Add("disallowed");
            bt2.Dapantungcau = lists2;
            StaticData.bt.Add(bt2);
            //baitap3
            BaiTapDienTu bt3 = new BaiTapDienTu();
            bt3.Debai = "While the television (1) _______ is increasingly becoming the focal point of our living " +
                "room, it would be easy to(2) _______ that its older relative, the radio is still there. But in" +
                "the rush to turn(3) _______ the TV and feast our eyes on all those fantastic visual(4) _______ ," +
                " we are missing out on a valuable(5) _______ of communication.The radio has all the talk(6) _______ , comedies," +
                " dramas and news(7) _______ the television has, and more besides." +
                " Late night shows have(8) _______ presenters to keep you " +
                "awake or send you to sleep, depending on your needs. Hard - hitting reporters(9) _______ " +
                "the hot items of the day with politicians and(10) _______ in specialized areas.";
            bt3.Dapan = "While the television (1) set is increasingly becoming the focal point of our living " +
                "room, it would be easy to(2) forget that its older relative, the radio is still there. But in" +
                "the rush to turn(3) on the TV and feast our eyes on all those fantastic visual(4) images ," +
                " we are missing out on a valuable(5) means of communication.The radio has all the talk(6) shows , comedies," +
                " dramas and news(7) bulletins the television has, and more besides." +
                " Late night shows have(8) likeable presenters to keep you " +
                "awake or send you to sleep, depending on your needs. Hard - hitting reporters(9) discuss " +
                "the hot items of the day with politicians and(10) experts in specialized areas.";
            List<string> lists3 = new List<string>();
            lists3.Add("set");
            lists3.Add("forget");
            lists3.Add("on");
            lists3.Add("images");
            lists3.Add("means");
            lists3.Add("shows");
            lists3.Add("bulletins");
            lists3.Add("likeable");
            lists3.Add("discuss");
            lists3.Add("experts");
            bt3.Dapantungcau = lists3;
            StaticData.bt.Add(bt3);
        }
        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

       
    }
}
