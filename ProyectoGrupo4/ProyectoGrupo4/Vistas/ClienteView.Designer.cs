﻿
namespace ProyectoGrupo4.Vistas
{
    partial class ClienteView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.GeneroTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EdadTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IdentidadMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.CorreoTextBox = new System.Windows.Forms.TextBox();
            this.ClienteDataGridView = new System.Windows.Forms.DataGridView();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IdTextBox);
            this.groupBox1.Controls.Add(this.GeneroTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EdadTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.IdentidadMaskedTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.NombreTextBox);
            this.groupBox1.Controls.Add(this.DireccionTextBox);
            this.groupBox1.Controls.Add(this.CorreoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(28, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 217);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(106, 33);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(166, 23);
            this.IdTextBox.TabIndex = 34;
            // 
            // GeneroTextBox
            // 
            this.GeneroTextBox.Enabled = false;
            this.GeneroTextBox.Location = new System.Drawing.Point(541, 165);
            this.GeneroTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GeneroTextBox.Name = "GeneroTextBox";
            this.GeneroTextBox.Size = new System.Drawing.Size(291, 23);
            this.GeneroTextBox.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "Genero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Identidad:";
            // 
            // EdadTextBox
            // 
            this.EdadTextBox.Enabled = false;
            this.EdadTextBox.Location = new System.Drawing.Point(541, 113);
            this.EdadTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EdadTextBox.Name = "EdadTextBox";
            this.EdadTextBox.Size = new System.Drawing.Size(291, 23);
            this.EdadTextBox.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Edad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Correo:";
            // 
            // IdentidadMaskedTextBox
            // 
            this.IdentidadMaskedTextBox.Location = new System.Drawing.Point(106, 76);
            this.IdentidadMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IdentidadMaskedTextBox.Mask = "####-####-#####";
            this.IdentidadMaskedTextBox.Name = "IdentidadMaskedTextBox";
            this.IdentidadMaskedTextBox.Size = new System.Drawing.Size(291, 23);
            this.IdentidadMaskedTextBox.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Dirección:";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Enabled = false;
            this.NombreTextBox.Location = new System.Drawing.Point(106, 121);
            this.NombreTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(291, 23);
            this.NombreTextBox.TabIndex = 35;
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Enabled = false;
            this.DireccionTextBox.Location = new System.Drawing.Point(541, 65);
            this.DireccionTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(291, 23);
            this.DireccionTextBox.TabIndex = 37;
            // 
            // CorreoTextBox
            // 
            this.CorreoTextBox.Enabled = false;
            this.CorreoTextBox.Location = new System.Drawing.Point(106, 165);
            this.CorreoTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CorreoTextBox.Name = "CorreoTextBox";
            this.CorreoTextBox.Size = new System.Drawing.Size(291, 23);
            this.CorreoTextBox.TabIndex = 36;
            // 
            // ClienteDataGridView
            // 
            this.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClienteDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ClienteDataGridView.Location = new System.Drawing.Point(0, 362);
            this.ClienteDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClienteDataGridView.Name = "ClienteDataGridView";
            this.ClienteDataGridView.RowHeadersWidth = 62;
            this.ClienteDataGridView.RowTemplate.Height = 28;
            this.ClienteDataGridView.Size = new System.Drawing.Size(919, 111);
            this.ClienteDataGridView.TabIndex = 51;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(647, 260);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(114, 54);
            this.CancelarButton.TabIndex = 50;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(525, 260);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(114, 54);
            this.EliminarButton.TabIndex = 49;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(407, 260);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(114, 54);
            this.GuardarButton.TabIndex = 48;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(164, 260);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(114, 54);
            this.NuevoButton.TabIndex = 47;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(284, 260);
            this.ModificarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(114, 54);
            this.ModificarButton.TabIndex = 46;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            // 
            // ClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClienteDataGridView);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.ModificarButton);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClienteView";
            this.Text = "Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox IdTextBox;
        public System.Windows.Forms.TextBox GeneroTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox EdadTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox IdentidadMaskedTextBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox NombreTextBox;
        public System.Windows.Forms.TextBox DireccionTextBox;
        public System.Windows.Forms.TextBox CorreoTextBox;
        public System.Windows.Forms.DataGridView ClienteDataGridView;
        public System.Windows.Forms.Button CancelarButton;
        public System.Windows.Forms.Button EliminarButton;
        public System.Windows.Forms.Button GuardarButton;
        public System.Windows.Forms.Button NuevoButton;
        public System.Windows.Forms.Button ModificarButton;
    }
}