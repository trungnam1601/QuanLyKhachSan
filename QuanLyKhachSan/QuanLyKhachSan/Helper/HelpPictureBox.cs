using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpers
{
    public partial class HelpPictureBox : UserControl
    {
        SolidBrush brush = new SolidBrush(Color.Purple);
        Graphics g;
        int currentIndex = 0;
        int[,] maxIndex = 
            new int[5, 4] { 
            { 1, 2, 1, 1 }, 
            { 1, 2, 1, 1 } , 
            { 1, 2, 1, 1 }, 
            { 1, 2, 1, 1 },
            { 1, 2, 1, 1 }};
        HELPERSTATE currentState = HELPERSTATE.ADDHELPER;
        CATSTATE currentObjectToRef = CATSTATE.Room;
        string[,] helpStringRoom = new string[4, 3] 
        { 
            { "B1: Điền thông tin phòng cần thêm vào các bảng", 
                "B2: Nhấp chuột trái vào nút Thêm để thêm phòng vào cơ sở dữ liệu","" }, 
            { "B1: Nhấp chuột trái 2 lần vào dòng hoặc nhập mã phòng cần sửa trong bảng hoặc gõ mã phòng vào trong ô", 
              "B2: Thay đổi thông tin ở trên các bảng",
              "B3: Nhấp chuột trái vào nút Sửa để cập nhập lại thông tin phòng" },
            { "B1: Nhấp chuột trái 2 lần vào dòng hoặc nhập mã phòng cần xoá", 
              "B2: Nhấp chuột trái vào nút Xoá để xoá phòng khỏi cơ sở dữ liệu","" },
            { "B1: Điền thông tin phòng cần tìm kiếm vào bảng", 
              "B2: Nhấp chuột trái vào nút tìm kiếm để in ra thông tin của các phòng tương đồng với thông tin đã nhập","" }
        };
        string[,] helpStringCustomer = new string[4, 3]
        {
            { "B1: Điền thông tin khách cần thêm vào các bảng",
              "B2: Nhấp chuột trái vào nút Thêm để thêm khách vào cơ sở dữ liệu","" },
            { "B1: Nhấp chuột trái 2 lần vào dòng hoặc nhập mã khách cần sửa trong bảng hoặc gõ mã khách vào trong ô",
              "B2: Thay đổi thông tin ở trên các bảng",
              "B3: Nhấp chuột trái vào nút Sửa để cập nhập lại thông tin khách" },
            { "B1: Nhấp chuột trái 2 lần vào dòng hoặc nhập mã khách cần xoá",
              "B2: Nhấp chuột trái vào nút Xoá để xoá khách khỏi cơ sở dữ liệu","" },
            { "B1: Điền thông tin khách cần tìm kiếm vào bảng",
              "B2: Nhấp chuột trái vào nút tìm kiếm để in ra thông tin của các khách tương đồng với thông tin đã nhập","" }
        };
        string[,] helpStringService = new string[4, 3]
        {
            { "B1: Điền thông tin dịch vụ cần thêm vào các bảng",
              "B2: Nhấp chuột trái vào nút Thêm để thêm dịch vụ vào cơ sở dữ liệu","" },
            { "B1: Nhấp chuột trái 2 lần vào dòng hoặc nhập mã dịch vụ cần sửa trong bảng hoặc gõ mã dịch vụ vào trong ô",
              "B2: Thay đổi thông tin ở trên các bảng",
              "B3: Nhấp chuột trái vào nút Sửa để cập nhập lại thông tin dịch vụ" },
            { "B1: Nhấp chuột trái 2 lần vào dòng hoặc nhập mã dịch vụ cần xoá",
              "B2: Nhấp chuột trái vào nút Xoá để xoá dịch vụ khỏi cơ sở dữ liệu","" },
            { "B1: Điền thông tin dịch vụ cần tìm kiếm vào bảng",
              "B2: Nhấp chuột trái vào nút tìm kiếm để in ra thông tin của các dịch vụ tương đồng với thông tin đã nhập","" }
        };
        string[,] helpStringStaff = new string[4, 3]
        {
            { "B1: Điền thông tin nhân viên cần thêm vào các bảng",
              "B2: Nhấp chuột trái vào nút Thêm để thêm nhân viên vào cơ sở dữ liệu","" },
            { "B1: Nhấp chuột trái 2 lần vào dòng hoặc nhập mã nhân viên cần sửa trong bảng hoặc gõ mã nhân viên vào trong ô",
              "B2: Thay đổi thông tin ở trên các bảng",
              "B3: Nhấp chuột trái vào nút Sửa để cập nhập lại thông tin nhân viên" },
            { "B1: Nhấp chuột trái 2 lần vào dòng hoặc nhập mã nhân viên cần xoá",
              "B2: Nhấp chuột trái vào nút Xoá để xoá nhân viên khỏi cơ sở dữ liệu","" },
            { "B1: Điền thông tin nhân viên cần tìm kiếm vào bảng",
              "B2: Nhấp chuột trái vào nút tìm kiếm để in ra thông tin của các nhân viên tương đồng với thông tin đã nhập","" }
        };
        string[,] helpStringProperty = new string[4, 3]
        {
            { "B1: Điền thông tin vật tư cần thêm vào các bảng",
              "B2: Nhấp chuột trái vào nút Thêm để thêm vật tư vào cơ sở dữ liệu","" },
            { "B1: Nhấp chuột trái 2 lần vào dòng hoặc nhập mã vật tư cần sửa trong bảng hoặc gõ mã vật tư vào trong ô",
              "B2: Thay đổi thông tin ở trên các bảng",
              "B3: Nhấp chuột trái vào nút Sửa để cập nhập lại thông tin vật tư" },
            { "B1: Nhấp chuột trái 2 lần vào dòng hoặc nhập mã vật tư cần xoá",
              "B2: Nhấp chuột trái vào nút Xoá để xoá vật tư khỏi cơ sở dữ liệu","" },
            { "B1: Điền thông tin vật tư cần tìm kiếm vào bảng",
              "B2: Nhấp chuột trái vào nút tìm kiếm để in ra thông tin của các vật tư tương đồng với thông tin đã nhập","" }
        };
        public HelpPictureBox()
        {
            InitializeComponent();
            g = progressBar.CreateGraphics();
            progressBar.Paint += progressPaint;
        }

        private void progressPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            float percentage = 1f / (maxIndex[(int)currentObjectToRef, (int)currentState] + 1);
            int width = Convert.ToInt32(progressBar.Width * percentage);
            Rectangle rectangle = new Rectangle(0, 0, width, progressBar.Height);
            e.Graphics.FillRectangle(brush, rectangle);
        }

        private void setImage(string filename)
        {
            switch(currentObjectToRef)
            {
                case CATSTATE.Room:
                    helpLabel.Text = helpStringRoom[(int)currentState, currentIndex];
                    checkLabeOverflow();
                    helperPic.Image = Image.FromFile(Application.StartupPath + "\\Image\\Room" + filename);
                    break;
                case CATSTATE.Customer:
                    helpLabel.Text = helpStringCustomer[(int)currentState, currentIndex];
                    checkLabeOverflow();
                    helperPic.Image = Image.FromFile(Application.StartupPath + "\\Image\\Customer" + filename);
                    break;
                case CATSTATE.Service:
                    helpLabel.Text = helpStringService[(int)currentState, currentIndex];
                    checkLabeOverflow();
                    helperPic.Image = Image.FromFile(Application.StartupPath + "\\Image\\Service" + filename);
                    break;
                case CATSTATE.Staff:
                    helpLabel.Text = helpStringStaff[(int)currentState, currentIndex];
                    checkLabeOverflow();
                    helperPic.Image = Image.FromFile(Application.StartupPath + "\\Image\\Staff" + filename);
                    break;
                case CATSTATE.Property:
                    helpLabel.Text = helpStringProperty[(int)currentState, currentIndex];
                    checkLabeOverflow();
                    helperPic.Image = Image.FromFile(Application.StartupPath + "\\Image\\Property" + filename);
                    break;
            }   

            helperPic.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void updateInformation(HELPERSTATE state,CATSTATE catstate, int index = 0)
        {
            //Pass
            if (index > maxIndex[(int)catstate, (int)currentState] || index < 0) return;

            index = define.Clamp(ref index, 0, maxIndex[(int)catstate, (int)currentState]);
            currentIndex = index;
            currentState = state;
            currentObjectToRef = catstate;
            FillProgressBar(index);
            switch (state)
            {
                case HELPERSTATE.ADDHELPER:
                    setImage("\\add" + index + ".png");
                    return;
                case HELPERSTATE.DELETEHELPER:
                    setImage("\\del" + index + ".png");
                    return;
                case HELPERSTATE.EDITHELPER:
                    setImage("\\edit" + index + ".png");
                    return;
                case HELPERSTATE.SEARCHHELPER:
                    setImage("\\search" + index + ".png");
                    return;
            }
        }

        private void FillProgressBar(int index)
        {
            g.Clear(Color.White);
            float percentage = (float)(index + 1) / ( maxIndex[(int)currentObjectToRef, (int)currentState] + 1);
            int width = Convert.ToInt32(progressBar.Width * percentage);
            Rectangle rectangle = new Rectangle(0, 0, width, progressBar.Height);
            
            g.FillRectangle(brush, rectangle);
        }

        private void previousBTN_Click(object sender, EventArgs e)
        {
            updateInformation(currentState,currentObjectToRef ,currentIndex - 1);
        }

        private void nextBTN_Click(object sender, EventArgs e)
        {
            updateInformation(currentState, currentObjectToRef, currentIndex + 1);
        }

        void checkLabeOverflow()
        {
            while (helpLabel.Width < System.Windows.Forms.TextRenderer.MeasureText(helpLabel.Text,
            new Font(helpLabel.Font.FontFamily, helpLabel.Font.Size, helpLabel.Font.Style)).Width)
            {
                helpLabel.Font = new Font(helpLabel.Font.FontFamily, helpLabel.Font.Size - 0.5f, helpLabel.Font.Style);
            }
        }

        private void helperPic_Resize(object sender, EventArgs e)
        {
            checkLabeOverflow();
        }
    }
}
