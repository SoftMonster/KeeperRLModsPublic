﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEffect
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UcLastingEffect1 = New KRLDeveloperNS.ucLastingEffect()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 43)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(776, 146)
        Me.TextBox1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Lasting <EFFECT>", "RemoveLasting <EFFECT>", "Permanent <EFFECT>", "Escape", "Teleport", "Heal FLESH", "Heal SPIRIT", "Fire", "Ice", "DestroyEquipment", "DestroyWalls", "Enhance WEAPON 1", "Enhance WEAPON 3", "Enhance WEAPON -1", "Enhance ARMOR 1", "Enhance ARMOR 3", "Enhance ARMOR -1", "EmitPoisonGas 0.2", "EmitPoisonGas 0.5", "EmitPoisonGas 0.8", "CircularBlast", "Deception", "DoubleTrouble", "Blast", "Pull", "Shove", "SwapPosition", "Wish", "TriggerTrap", "SummonElement", "Acid", "Alarm true", "Alarm false", "TeleEnemies", "SilverDamage", "RegrowBodyPart", "Suicide DIE", "SummonEnemy ""DJINN"" {1}", "SummonEnemy ""AUTOMATON"" {1}", "Summon ""FLY"" {3 7}", "Summon ""FIRE_ELEMENTAL"" { 2 4 }  ", "SummonGhost 100 { 3", "IncreaseAttr DAMAGE 1", "IncreaseAttr RANGED_DAMAGE 1", "IncreaseAttr SPELL_DAMAGE 1", "IncreaseAttr DEFENSE 1", "PlaceFurniture ""METEOR_SHOWER""", "Damage SPELL_DAMAGE SPELL", "Area 2 Filter ALLY Lasting SPEED", "Area 2 Filter ENEMY Lasting BLIND", "CustomArea PlaceFurniture ""FIRE_WALL"" { 0 -2 0 -1 0 0 0 1 0 2 }", "Message ""Nothing seems to happen."""})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(235, 24)
        Me.ComboBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(713, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(620, 12)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(87, 22)
        Me.TextBox2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(554, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Chance:"
        '
        'UcLastingEffect1
        '
        Me.UcLastingEffect1.Location = New System.Drawing.Point(391, 11)
        Me.UcLastingEffect1.Name = "UcLastingEffect1"
        Me.UcLastingEffect1.Size = New System.Drawing.Size(157, 25)
        Me.UcLastingEffect1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(293, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "<EFFECT> = "
        '
        'frmEffect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 205)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UcLastingEffect1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frmEffect"
        Me.Text = "frmEffect"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents UcLastingEffect1 As ucLastingEffect
    Friend WithEvents Label2 As Label
End Class
