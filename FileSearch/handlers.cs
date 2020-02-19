using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSearch
{
    static class handlers
    {
        /// <summary>
        /// Главная (родительская) форма
        /// </summary>
        public static main_form form;

        /// <summary>
        /// Передаём родительскую форму при запуске
        /// </summary>
        /// <param name="_form">Родительская форма</param>
        public static void init (main_form _form)
        {
            form = _form;
            form.current_folder_lbl.Text = "Please choose folder";
            //tooltips
            ToolTip tt = new ToolTip();
            tt.SetToolTip(form.current_folder_lbl, "Path to current folder");
            tt.SetToolTip(form.folder_name_lbl, "Current folder name");

        }
        
        /// <summary>
        /// Выбираем папку поиска
        /// </summary>
        public static void chosing_folder ()
        {
            System.Windows.Forms.DialogResult result = form.folder_dialog_fbd.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                settings.folder_path = form.folder_dialog_fbd.SelectedPath;
                form.current_folder_lbl.Text = settings.folder_path;
                //form.folder_name_lbl.Text = Path.GetFileName(Path.GetDirectoryName(settings.folder_path + @"\"));
                form.folder_name_lbl.Text = new DirectoryInfo(settings.folder_path).Name;
            }
        }
    }
}
