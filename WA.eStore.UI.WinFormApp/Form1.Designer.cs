
namespace WA.eStore.UI.WinFormApp
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.City = new System.Windows.Forms.ComboBox();
			this.Village = new System.Windows.Forms.ComboBox();
			this.ZipCode = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// City
			// 
			this.City.FormattingEnabled = true;
			this.City.Location = new System.Drawing.Point(52, 35);
			this.City.Name = "City";
			this.City.Size = new System.Drawing.Size(121, 20);
			this.City.TabIndex = 0;
			this.City.SelectedIndexChanged += new System.EventHandler(this.City_SelectedIndexChanged);
			// 
			// Village
			// 
			this.Village.FormattingEnabled = true;
			this.Village.Location = new System.Drawing.Point(52, 76);
			this.Village.Name = "Village";
			this.Village.Size = new System.Drawing.Size(121, 20);
			this.Village.TabIndex = 1;
			this.Village.SelectedIndexChanged += new System.EventHandler(this.Village_SelectedIndexChanged);
			// 
			// ZipCode
			// 
			this.ZipCode.AutoSize = true;
			this.ZipCode.Location = new System.Drawing.Point(52, 119);
			this.ZipCode.Name = "ZipCode";
			this.ZipCode.Size = new System.Drawing.Size(33, 12);
			this.ZipCode.TabIndex = 2;
			this.ZipCode.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ZipCode);
			this.Controls.Add(this.Village);
			this.Controls.Add(this.City);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox City;
		private System.Windows.Forms.ComboBox Village;
		private System.Windows.Forms.Label ZipCode;
	}
}

