
namespace Ejercicion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1ConvertirConversores = new System.Windows.Forms.Button();
            this.lbl1DeConversores = new System.Windows.Forms.Label();
            this.cbo1DeConversores = new System.Windows.Forms.ComboBox();
            this.txt1CantidadConversores = new System.Windows.Forms.TextBox();
            this.cbo2Aconversores = new System.Windows.Forms.ComboBox();
            this.lbl2AConversores = new System.Windows.Forms.Label();
            this.lbl3CantidadConversores = new System.Windows.Forms.Label();
            this.lbl4RespuestaConversores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1ConvertirConversores
            // 
            this.btn1ConvertirConversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1ConvertirConversores.Location = new System.Drawing.Point(82, 283);
            this.btn1ConvertirConversores.Name = "btn1ConvertirConversores";
            this.btn1ConvertirConversores.Size = new System.Drawing.Size(123, 53);
            this.btn1ConvertirConversores.TabIndex = 0;
            this.btn1ConvertirConversores.Text = "Convertir";
            this.btn1ConvertirConversores.UseVisualStyleBackColor = true;
            this.btn1ConvertirConversores.Click += new System.EventHandler(this.btn1ConvertirConversores_Click);
            // 
            // lbl1DeConversores
            // 
            this.lbl1DeConversores.AutoSize = true;
            this.lbl1DeConversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1DeConversores.Location = new System.Drawing.Point(21, 75);
            this.lbl1DeConversores.Name = "lbl1DeConversores";
            this.lbl1DeConversores.Size = new System.Drawing.Size(40, 22);
            this.lbl1DeConversores.TabIndex = 1;
            this.lbl1DeConversores.Text = "De:";
            // 
            // cbo1DeConversores
            // 
            this.cbo1DeConversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo1DeConversores.FormattingEnabled = true;
            this.cbo1DeConversores.Items.AddRange(new object[] {
            "dolar",
            "Euro",
            "Quetzal",
            "Lempira",
            "Cordoba",
            "Colon SV",
            "Colon CR",
            "Yenes",
            "Rupias India",
            "Libras Esterlinas"});
            this.cbo1DeConversores.Location = new System.Drawing.Point(67, 79);
            this.cbo1DeConversores.Name = "cbo1DeConversores";
            this.cbo1DeConversores.Size = new System.Drawing.Size(149, 21);
            this.cbo1DeConversores.TabIndex = 2;
            // 
            // txt1CantidadConversores
            // 
            this.txt1CantidadConversores.Location = new System.Drawing.Point(116, 187);
            this.txt1CantidadConversores.Name = "txt1CantidadConversores";
            this.txt1CantidadConversores.Size = new System.Drawing.Size(100, 20);
            this.txt1CantidadConversores.TabIndex = 3;
            // 
            // cbo2Aconversores
            // 
            this.cbo2Aconversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo2Aconversores.FormattingEnabled = true;
            this.cbo2Aconversores.Items.AddRange(new object[] {
            "dolar",
            "Euro",
            "Quetzal",
            "Lempira",
            "Cordoba",
            "Colon SV",
            "Colon CR",
            "Yenes",
            "Rupias India",
            "Libras Esterlinas"});
            this.cbo2Aconversores.Location = new System.Drawing.Point(55, 130);
            this.cbo2Aconversores.Name = "cbo2Aconversores";
            this.cbo2Aconversores.Size = new System.Drawing.Size(163, 21);
            this.cbo2Aconversores.TabIndex = 5;
            // 
            // lbl2AConversores
            // 
            this.lbl2AConversores.AutoSize = true;
            this.lbl2AConversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2AConversores.Location = new System.Drawing.Point(21, 129);
            this.lbl2AConversores.Name = "lbl2AConversores";
            this.lbl2AConversores.Size = new System.Drawing.Size(28, 22);
            this.lbl2AConversores.TabIndex = 4;
            this.lbl2AConversores.Text = "A:";
            // 
            // lbl3CantidadConversores
            // 
            this.lbl3CantidadConversores.AutoSize = true;
            this.lbl3CantidadConversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3CantidadConversores.Location = new System.Drawing.Point(21, 185);
            this.lbl3CantidadConversores.Name = "lbl3CantidadConversores";
            this.lbl3CantidadConversores.Size = new System.Drawing.Size(90, 22);
            this.lbl3CantidadConversores.TabIndex = 6;
            this.lbl3CantidadConversores.Text = "Cantidad:";
            // 
            // lbl4RespuestaConversores
            // 
            this.lbl4RespuestaConversores.AutoSize = true;
            this.lbl4RespuestaConversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4RespuestaConversores.Location = new System.Drawing.Point(21, 231);
            this.lbl4RespuestaConversores.Name = "lbl4RespuestaConversores";
            this.lbl4RespuestaConversores.Size = new System.Drawing.Size(112, 22);
            this.lbl4RespuestaConversores.TabIndex = 7;
            this.lbl4RespuestaConversores.Text = "Respuesta: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 361);
            this.Controls.Add(this.lbl4RespuestaConversores);
            this.Controls.Add(this.lbl3CantidadConversores);
            this.Controls.Add(this.cbo2Aconversores);
            this.Controls.Add(this.lbl2AConversores);
            this.Controls.Add(this.txt1CantidadConversores);
            this.Controls.Add(this.cbo1DeConversores);
            this.Controls.Add(this.lbl1DeConversores);
            this.Controls.Add(this.btn1ConvertirConversores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1ConvertirConversores;
        private System.Windows.Forms.Label lbl1DeConversores;
        private System.Windows.Forms.ComboBox cbo1DeConversores;
        private System.Windows.Forms.TextBox txt1CantidadConversores;
        private System.Windows.Forms.ComboBox cbo2Aconversores;
        private System.Windows.Forms.Label lbl2AConversores;
        private System.Windows.Forms.Label lbl3CantidadConversores;
        private System.Windows.Forms.Label lbl4RespuestaConversores;
    }
}

