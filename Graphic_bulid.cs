#pragma once

namespace WindowsFormsApplication19 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	double Xe[1000];//масив із координатами аргументів графіку
	double Ye[1000];//масив із координатами точок графіку
	/// <summary>
	/// Summary for Form1
	/// </summary>
	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::PictureBox^  pictureBox1;
	protected: 
	private: System::Windows::Forms::GroupBox^  groupBox1;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::Label^  label4;
	private: System::Windows::Forms::Label^  label5;
	private: System::Windows::Forms::Label^  label6;
	private: System::Windows::Forms::Button^  button2;
	private: System::Windows::Forms::Button^  button1;
	private: System::Windows::Forms::NumericUpDown^  numericUpDown3;
	private: System::Windows::Forms::NumericUpDown^  numericUpDown2;
	private: System::Windows::Forms::NumericUpDown^  numericUpDown1;
	private: System::Windows::Forms::Label^  label9;
	private: System::Windows::Forms::Label^  label8;
	private: System::Windows::Forms::Label^  label7;
	private: System::Windows::Forms::TextBox^  textBox1;
	private: System::Windows::Forms::TextBox^  textBox2;
	private: System::Windows::Forms::TextBox^  textBox3;

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->pictureBox1 = (gcnew System::Windows::Forms::PictureBox());
			this->groupBox1 = (gcnew System::Windows::Forms::GroupBox());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->numericUpDown3 = (gcnew System::Windows::Forms::NumericUpDown());
			this->numericUpDown2 = (gcnew System::Windows::Forms::NumericUpDown());
			this->numericUpDown1 = (gcnew System::Windows::Forms::NumericUpDown());
			this->label9 = (gcnew System::Windows::Forms::Label());
			this->label8 = (gcnew System::Windows::Forms::Label());
			this->label7 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->label6 = (gcnew System::Windows::Forms::Label());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->textBox2 = (gcnew System::Windows::Forms::TextBox());
			this->textBox3 = (gcnew System::Windows::Forms::TextBox());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox1))->BeginInit();
			this->groupBox1->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->numericUpDown3))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->numericUpDown2))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->numericUpDown1))->BeginInit();
			this->SuspendLayout();
			// 
			// pictureBox1
			// 
			this->pictureBox1->Location = System::Drawing::Point(4, 3);
			this->pictureBox1->Name = L"pictureBox1";
			this->pictureBox1->Size = System::Drawing::Size(871, 271);
			this->pictureBox1->TabIndex = 0;
			this->pictureBox1->TabStop = false;
			// 
			// groupBox1
			// 
			this->groupBox1->Controls->Add(this->button2);
			this->groupBox1->Controls->Add(this->button1);
			this->groupBox1->Controls->Add(this->numericUpDown3);
			this->groupBox1->Controls->Add(this->numericUpDown2);
			this->groupBox1->Controls->Add(this->numericUpDown1);
			this->groupBox1->Controls->Add(this->label9);
			this->groupBox1->Controls->Add(this->label8);
			this->groupBox1->Controls->Add(this->label7);
			this->groupBox1->Controls->Add(this->label2);
			this->groupBox1->Location = System::Drawing::Point(255, 281);
			this->groupBox1->Name = L"groupBox1";
			this->groupBox1->Size = System::Drawing::Size(620, 177);
			this->groupBox1->TabIndex = 1;
			this->groupBox1->TabStop = false;
			this->groupBox1->Text = L"Параметри графіку";
			this->groupBox1->Enter += gcnew System::EventHandler(this, &Form1::groupBox1_Enter);
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(296, 113);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(75, 23);
			this->button2->TabIndex = 22;
			this->button2->Text = L"Вихід";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &Form1::button2_Click);
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(296, 63);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(75, 23);
			this->button1->TabIndex = 18;
			this->button1->Text = L"Побудова";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &Form1::button1_Click);
			// 
			// numericUpDown3
			// 
			this->numericUpDown3->Location = System::Drawing::Point(180, 145);
			this->numericUpDown3->Name = L"numericUpDown3";
			this->numericUpDown3->Size = System::Drawing::Size(38, 20);
			this->numericUpDown3->TabIndex = 20;
			this->numericUpDown3->Value = System::Decimal(gcnew cli::array< System::Int32 >(4) {1, 0, 0, 0});
			// 
			// numericUpDown2
			// 
			this->numericUpDown2->Location = System::Drawing::Point(181, 106);
			this->numericUpDown2->Name = L"numericUpDown2";
			this->numericUpDown2->Size = System::Drawing::Size(38, 20);
			this->numericUpDown2->TabIndex = 19;
			this->numericUpDown2->Value = System::Decimal(gcnew cli::array< System::Int32 >(4) {2, 0, 0, 0});
			// 
			// numericUpDown1
			// 
			this->numericUpDown1->Location = System::Drawing::Point(180, 71);
			this->numericUpDown1->Name = L"numericUpDown1";
			this->numericUpDown1->Size = System::Drawing::Size(38, 20);
			this->numericUpDown1->TabIndex = 18;
			this->numericUpDown1->Value = System::Decimal(gcnew cli::array< System::Int32 >(4) {3, 0, 0, 0});
			// 
			// label9
			// 
			this->label9->AutoSize = true;
			this->label9->Location = System::Drawing::Point(27, 152);
			this->label9->Name = L"label9";
			this->label9->Size = System::Drawing::Size(124, 13);
			this->label9->TabIndex = 10;
			this->label9->Text = L"Товщина лінії гратки = ";
			// 
			// label8
			// 
			this->label8->AutoSize = true;
			this->label8->Location = System::Drawing::Point(27, 113);
			this->label8->Name = L"label8";
			this->label8->Size = System::Drawing::Size(148, 13);
			this->label8->TabIndex = 8;
			this->label8->Text = L"Товщина осей координат = ";
			// 
			// label7
			// 
			this->label7->AutoSize = true;
			this->label7->Location = System::Drawing::Point(27, 73);
			this->label7->Name = L"label7";
			this->label7->Size = System::Drawing::Size(147, 13);
			this->label7->TabIndex = 6;
			this->label7->Text = L"Товщина лінії графіку ф-ії  =";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(27, 32);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(178, 13);
			this->label2->TabIndex = 4;
			this->label2->Text = L"Оберіть,при потребі,інші значення";
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(24, 293);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(158, 13);
			this->label1->TabIndex = 2;
			this->label1->Text = L"Введіть межі зміни аргументу";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(24, 324);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(27, 13);
			this->label3->TabIndex = 6;
			this->label3->Text = L"al = ";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(24, 357);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(27, 13);
			this->label4->TabIndex = 8;
			this->label4->Text = L"bl = ";
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Location = System::Drawing::Point(17, 394);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(165, 13);
			this->label5->TabIndex = 10;
			this->label5->Text = L"Введіть кількість точок графіку";
			this->label5->Click += gcnew System::EventHandler(this, &Form1::label5_Click);
			// 
			// label6
			// 
			this->label6->AutoSize = true;
			this->label6->Location = System::Drawing::Point(24, 433);
			this->label6->Name = L"label6";
			this->label6->Size = System::Drawing::Size(30, 13);
			this->label6->TabIndex = 12;
			this->label6->Text = L"Ne =";
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(57, 324);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(100, 20);
			this->textBox1->TabIndex = 13;
			// 
			// textBox2
			// 
			this->textBox2->Location = System::Drawing::Point(57, 354);
			this->textBox2->Name = L"textBox2";
			this->textBox2->Size = System::Drawing::Size(100, 20);
			this->textBox2->TabIndex = 15;
			// 
			// textBox3
			// 
			this->textBox3->Location = System::Drawing::Point(60, 430);
			this->textBox3->Name = L"textBox3";
			this->textBox3->Size = System::Drawing::Size(100, 20);
			this->textBox3->TabIndex = 17;
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(882, 470);
			this->Controls->Add(this->textBox3);
			this->Controls->Add(this->textBox2);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->label6);
			this->Controls->Add(this->label5);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->groupBox1);
			this->Controls->Add(this->pictureBox1);
			this->Name = L"Form1";
			this->Text = L"Графік";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox1))->EndInit();
			this->groupBox1->ResumeLayout(false);
			this->groupBox1->PerformLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->numericUpDown3))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->numericUpDown2))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->numericUpDown1))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
double Kx,Ky,Zx,Zy;//коофіцієнти масштабування
double al,bl;//область визначення функції
int Ne;//Ne кількість точок графіку
double maxx,maxy,minx,miny;//для обчислення коофіцієнтів масштабування
double krx,kry,xx,yy,Gx,Gy;//для виведення осей координат та їхніх підписів
int KrokX,KrokY,L;
double f(double x){
	return x*x;
}
void TabF(double Xe[1000],double Ye[1000])
{double h;
h=(bl-al)/Ne;
Xe[0]=al;
for(int i=0;i<=Ne-1;i++){
	Ye[i]=f(Xe[i]);
	Xe[i+1]=Xe[i]+h;
}
}
	private: System::Void groupBox1_Enter(System::Object^  sender, System::EventArgs^  e) {
			 }
	private: System::Void label5_Click(System::Object^  sender, System::EventArgs^  e) {
			 }
private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
	Pen^pen1 = gcnew Pen(Color::Blue,	(float)(numericUpDown1->Value));//колір графа
	Pen^pen2 = gcnew Pen(Color::Red,	(float)(numericUpDown2->Value));//колір осей координат
    Pen^pen3 = gcnew Pen(Color::Green,	(float)(numericUpDown3->Value));//колір гратки
	Graphics^g=pictureBox1->CreateGraphics();//створення об'єкта для роботи з графікою	 
	g->Clear(Color::White);//Очищення об'єкта для роботи з графікою
    int pb_Height = pictureBox1->Height;//висота в пікселях компоненти pictureBox1	
	int pb_Width = pictureBox1->Width;	//ширина в пікселях компоненти pictureBox1
	L=40;//відступ від країв компоненти pictureBox1
	//Вводимо область визначення графіка і кількість його точок
	al = Convert::ToDouble(textBox1->Text);
	bl = Convert::ToDouble(textBox2->Text);
	Ne = Convert::ToDouble(textBox3->Text);
	TabF(Xe,Ye);//табулюєм функцію із записом результатів у масиви
	//Знаходимо екстремуми аргумента і функції для обчислення коефіцієнтів масштабування
	minx=Xe[0];    maxx=Xe[Ne-1];   miny=Ye[0];  maxy=Ye[0];
	for(int i=1;i<=Ne-1;i++)
	{
		if(maxy<Ye[i]) maxy=Ye[i];
		if (miny>Ye[i]) miny=Ye[i];
		 }
	Kx=(pb_Width-2*L)/(maxx-minx);
	Ky=(pb_Height-2*L)/(miny-maxy);
	Zx=(pb_Width*minx-L*(maxx+minx))/(minx-maxx);
	Zy=(pb_Height*maxy-L*(miny+maxy))/(maxy-miny);
	//Обчислюємо розшташування плаваючих(рухомих) осей координат
		if(minx * maxx <= 0.0)                Gx=0.0;
		if(minx * maxx > 0.0)                 Gx=minx;
		if(minx*  maxx > 0.0 && minx < 0.0)   Gx=maxx;
		if(miny*  maxy <= 0.0)                Gy=0.0;
		if(miny*maxy>0.0 && miny>0.0)         Gy=miny;
		if(miny *  maxy > 0.0 && miny < 00)   Gy=maxy;
		//Обчислюємо цілочисельні відстані між лініями гратки
		KrokX = (pb_Width - 2 * L ) / 10;
		KrokY = (pb_Height - 2 * L ) / 9;
		//Виводимо гратку
		 for(int i=1;i<30;i++){
g->DrawLine(pen3,L,Math::Round(Ky + Gy + Zy,4) + i * KrokY,pb_Width - L,
	Math::Round(Ky * Gy + Zy,4) + i * KrokY);
 g->DrawLine(pen3,L,Math::Round(Ky + Gy + Zy,4) - i * KrokY,pb_Width - L,
	Math::Round(Ky* Gy + Zy,4) - i * KrokY);
		 }
for(int i=1;i<30;i++){
        g->DrawLine(pen3,Math::Round(Kx * Gx + Zx,4) + i * KrokX, L - 20,Math::Round(Kx * Gx + Zx,4) + i * KrokX,pb_Height - L + 30);
        g->DrawLine(pen3,Math::Round(Kx * Gx + Zx,4) - i * KrokX, L - 20,Math::Round(Kx * Gx + Zx,4) - i * KrokX,pb_Height - L + 30);
		 }
//Програмуємо підписи масштабних поділок на осях координат
		 xx = minx; yy = maxy;
		 krx = (maxx-minx)/10.0;
		 kry = (maxy - miny)/10.6;
for(int i=0;i<12;i++)
		 {
		 g->DrawString(Convert::ToString(Math::Round(xx,1)),gcnew Drawing::Font("Times",8),Brushes::Black,L+4+i*KrokX,Math::Round(Ky*Gy+Zy,4)-L+40.0f);
		 g->DrawString(Convert::ToString(Math::Round(yy,1)),gcnew Drawing::Font("Times",8),Brushes::Black,Math::Round(Kx*Gx+Zx,4)-L+10.0f,(float)(L+i*KrokY)-24.0f);
		 xx= xx + krx;
		 yy= yy - kry;
		 }
                //малюємо вісі координат
		 g->DrawLine(pen2,L,Math::Round(Ky*Gy+Zy,4),Math::Round(pb_Width-10,4), Math::Round(Ky*Gy+Zy,4));//вісь у
		 g->DrawLine(pen2,Math::Round(Kx*Gx+Zx,4),10,Math::Round(Kx*Gx+Zx,4),Math::Round(pb_Height-10,4));//вісь х
				 //малюємо графік функції
for(int i=1;i<=Ne-1;i++){
					 g->DrawLine(pen1,Math::Round(Kx*Xe[i-1]+Zx,4),Math::Round(Ky*Ye[i-1]+Zy,4),Math::Round(Kx*Xe[i]+Zx,4),
						 Convert::ToInt32(Math::Round(Ky*Ye[i]+Zy,4)));
      }
		 }
private: System::Void button2_Click(System::Object^  sender, System::EventArgs^  e) {
			 Close();
		 }
};
}

