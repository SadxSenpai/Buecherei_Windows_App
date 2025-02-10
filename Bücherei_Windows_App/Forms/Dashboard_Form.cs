using System.Runtime.InteropServices;

namespace Bücherei_Windows_App.Forms
{
    public partial class Dashboard_Form : Form
    {
        // Konstruktor für das Dashboard-Formular
        // Constructor for the dashboard form
        public Dashboard_Form()
        {
            InitializeComponent();
        }

        // Ereignishandler für das Klicken auf das Exit-Label
        // Event handler for clicking the exit label
        void exit_dash_label_Click(object sender, EventArgs e) => Application.Exit();

        // Ereignishandler für das MouseEnter-Ereignis des Exit-Labels
        // Event handler for the MouseEnter event of the exit label
        void exit_dash_label_MouseEnter(object sender, EventArgs e)
        {
            exit_dash_label.ForeColor = Color.Red;
        }

        // Ereignishandler für das MouseLeave-Ereignis des Exit-Labels
        // Event handler for the MouseLeave event of the exit label
        void exit_dash_label_MouseLeave(object sender, EventArgs e) => exit_dash_label.ForeColor = Color.White;

        // Ereignishandler für das Klicken auf das Minimize-Label
        // Event handler for clicking the minimize label
        void mini_dash_label_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Ereignishandler für das MouseEnter-Ereignis des Minimize-Labels
        // Event handler for the MouseEnter event of the minimize label
        void mini_dash_label_MouseEnter(object sender, EventArgs e)
        {
            mini_dash_label.ForeColor = Color.Red;
        }

        // Ereignishandler für das MouseLeave-Ereignis des Minimize-Labels
        // Event handler for the MouseLeave event of the minimize label
        void mini_dash_label_MouseLeave(object sender, EventArgs e) => mini_dash_label.ForeColor = Color.White;

        // Ereignishandler für das Laden des Dashboard-Formulars
        // Event handler for loading the dashboard form
        void Dashboard_Form_Load(object sender, EventArgs e)
        {
            // Setzt das Dashboard-Formular als Shadow-Form
            // Sets the dashboard form as a shadow form
            guna2ShadowForm1.SetShadowForm(this);

            // Aktiviert den Blur-Effekt
            // Enables the blur effect
            this.EnableBlur();
            TransparencyKey = Color.LimeGreen;

            // Entfernt und bereinigt alle UserControls beim Laden
            // Removes and cleans up all user controls on load
            Controls.Remove(itemout_uc1);
            itemout_uc1.Dispose();
            itemout_uc1 = null;

            Controls.Remove(booklist_uc1);
            booklist_uc1.Dispose();
            booklist_uc1 = null;

            Controls.Remove(book_add_uc1);
            book_add_uc1.Dispose();
            book_add_uc1 = null;

            Controls.Remove(book_Out_uc1);
            book_Out_uc1.Dispose();
            book_Out_uc1 = null;

            Controls.Remove(book_In_uc1);
            book_In_uc1.Dispose();
            book_In_uc1 = null;

            Controls.Remove(userlist_uc1);
            userlist_uc1.Dispose();
            userlist_uc1 = null;

            Controls.Remove(user_Add_uc1);
            user_Add_uc1.Dispose();
            user_Add_uc1 = null;

            Controls.Remove(book_Del_uc1);
            book_Del_uc1.Dispose();
            book_Del_uc1 = null;
        }

        // Ereignishandler für das Anzeigen des Dashboard-Formulars
        // Event handler for showing the dashboard form
        void Dashboard_Form_Shown(object sender, EventArgs e)
        {
            Enabled = false;

            // Zeigt das Login-Formular an
            // Shows the login form
            var logf = new Login_Form(this);
            logf.BringToFront();
            logf.Show();
        }

        // Ereignishandler für das Klicken auf die Bücherliste
        // Event handler for clicking the books list
        void Books_list_Click(object sender, EventArgs e)
        {
            booklist_uc1 = new Itemlist_UC();
            Controls.Add(booklist_uc1);
            booklist_uc1.BringToFront();

            // Schließt andere UserControls
            // Closes other user controls
            if (book_Out_uc1 != null)
            {
                Controls.Remove(book_Out_uc1);
                book_Out_uc1.Dispose();
                book_Out_uc1 = null;
            }

            if (userlist_uc1 != null)
            {
                Controls.Remove(userlist_uc1);
                userlist_uc1.Dispose();
                userlist_uc1 = null;
            }

            if (book_In_uc1 != null)
            {
                Controls.Remove(book_In_uc1);
                book_In_uc1.Dispose();
                book_In_uc1 = null;
            }

            if (book_add_uc1 != null)
            {
                Controls.Remove(book_add_uc1);
                book_add_uc1.Dispose();
                book_add_uc1 = null;
            }

            if (user_Add_uc1 != null)
            {
                Controls.Remove(user_Add_uc1);
                user_Add_uc1.Dispose();
                user_Add_uc1 = null;
            }

            if (book_Del_uc1 != null)
            {
                Controls.Remove(book_Del_uc1);
                book_Del_uc1.Dispose();
                book_Del_uc1 = null;
            }

            if (itemout_uc1 != null)
            {
                Controls.Remove(itemout_uc1);
                itemout_uc1.Dispose();
                itemout_uc1 = null;
            }
        }

        // Ereignishandler für das Klicken auf den Ausleih-Button
        // Event handler for clicking the borrow button
        void Ausleih_button_Click(object sender, EventArgs e)
        {
            book_Out_uc1 = new Item_Out_UC();
            Controls.Add(book_Out_uc1);
            book_Out_uc1.BringToFront();

            // Schließt andere UserControls
            // Closes other user controls
            if (booklist_uc1 != null)
            {
                Controls.Remove(booklist_uc1);
                booklist_uc1.Dispose();
                booklist_uc1 = null;
            }

            if (userlist_uc1 != null)
            {
                Controls.Remove(userlist_uc1);
                userlist_uc1.Dispose();
                userlist_uc1 = null;
            }

            if (book_In_uc1 != null)
            {
                Controls.Remove(book_In_uc1);
                book_In_uc1.Dispose();
                book_In_uc1 = null;
            }

            if (book_add_uc1 != null)
            {
                Controls.Remove(book_add_uc1);
                book_add_uc1.Dispose();
                book_add_uc1 = null;
            }

            if (user_Add_uc1 != null)
            {
                Controls.Remove(user_Add_uc1);
                user_Add_uc1.Dispose();
                user_Add_uc1 = null;
            }

            if (book_Del_uc1 != null)
            {
                Controls.Remove(book_Del_uc1);
                book_Del_uc1.Dispose();
                book_Del_uc1 = null;
            }

            if (itemout_uc1 != null)
            {
                Controls.Remove(itemout_uc1);
                itemout_uc1.Dispose();
                itemout_uc1 = null;
            }
        }

        // Ereignishandler für das Klicken auf den Rückgabe-Button
        // Event handler for clicking the return button
        void Rueckgabe_button_Click(object sender, EventArgs e)
        {
            book_In_uc1 = new Item_In_UC();
            Controls.Add(book_In_uc1);
            book_In_uc1.BringToFront();

            // Schließt andere UserControls
            // Closes other user controls
            if (booklist_uc1 != null)
            {
                Controls.Remove(booklist_uc1);
                booklist_uc1.Dispose();
                booklist_uc1 = null;
            }

            if (userlist_uc1 != null)
            {
                Controls.Remove(userlist_uc1);
                userlist_uc1.Dispose();
                userlist_uc1 = null;
            }

            if (book_Out_uc1 != null)
            {
                Controls.Remove(book_Out_uc1);
                book_Out_uc1.Dispose();
                book_Out_uc1 = null;
            }

            if (book_add_uc1 != null)
            {
                Controls.Remove(book_add_uc1);
                book_add_uc1.Dispose();
                book_add_uc1 = null;
            }

            if (user_Add_uc1 != null)
            {
                Controls.Remove(user_Add_uc1);
                user_Add_uc1.Dispose();
                user_Add_uc1 = null;
            }

            if (book_Del_uc1 != null)
            {
                Controls.Remove(book_Del_uc1);
                book_Del_uc1.Dispose();
                book_Del_uc1 = null;
            }

            if (itemout_uc1 != null)
            {
                Controls.Remove(itemout_uc1);
                itemout_uc1.Dispose();
                itemout_uc1 = null;
            }
        }

        // Ereignishandler für das Klicken auf die Benutzerliste
        // Event handler for clicking the user list
        void User_list_Click(object sender, EventArgs e)
        {
            userlist_uc1 = new Userlist_UC();
            Controls.Add(userlist_uc1);
            userlist_uc1.BringToFront();

            // Schließt andere UserControls
            // Closes other user controls
            if (booklist_uc1 != null)
            {
                Controls.Remove(booklist_uc1);
                booklist_uc1.Dispose();
                booklist_uc1 = null;
            }

            if (book_Out_uc1 != null)
            {
                Controls.Remove(book_Out_uc1);
                book_Out_uc1.Dispose();
                book_Out_uc1 = null;
            }

            if (book_In_uc1 != null)
            {
                Controls.Remove(book_In_uc1);
                book_In_uc1.Dispose();
                book_In_uc1 = null;
            }

            if (book_add_uc1 != null)
            {
                Controls.Remove(book_add_uc1);
                book_add_uc1.Dispose();
                book_add_uc1 = null;
            }

            if (user_Add_uc1 != null)
            {
                Controls.Remove(user_Add_uc1);
                user_Add_uc1.Dispose();
                user_Add_uc1 = null;
            }

            if (book_Del_uc1 != null)
            {
                Controls.Remove(book_Del_uc1);
                book_Del_uc1.Dispose();
                book_Del_uc1 = null;
            }

            if (itemout_uc1 != null)
            {
                Controls.Remove(itemout_uc1);
                itemout_uc1.Dispose();
                itemout_uc1 = null;
            }
        }

        // Ereignishandler für das Klicken auf den Button zum Hinzufügen eines neuen Buches
        // Event handler for clicking the add new book button
        void book_add_new_Click(object sender, EventArgs e)
        {
            book_add_uc1 = new Item_add_UC();
            Controls.Add(book_add_uc1);
            book_add_uc1.BringToFront();

            // Schließt andere UserControls
            // Closes other user controls
            if (booklist_uc1 != null)
            {
                Controls.Remove(booklist_uc1);
                booklist_uc1.Dispose();
                booklist_uc1 = null;
            }

            if (book_Out_uc1 != null)
            {
                Controls.Remove(book_Out_uc1);
                book_Out_uc1.Dispose();
                book_Out_uc1 = null;
            }

            if (book_In_uc1 != null)
            {
                Controls.Remove(book_In_uc1);
                book_In_uc1.Dispose();
                book_In_uc1 = null;
            }

            if (userlist_uc1 != null)
            {
                Controls.Remove(userlist_uc1);
                userlist_uc1.Dispose();
                userlist_uc1 = null;
            }

            if (user_Add_uc1 != null)
            {
                Controls.Remove(user_Add_uc1);
                user_Add_uc1.Dispose();
                user_Add_uc1 = null;
            }

            if (book_Del_uc1 != null)
            {
                Controls.Remove(book_Del_uc1);
                book_Del_uc1.Dispose();
                book_Del_uc1 = null;
            }

            if (itemout_uc1 != null)
            {
                Controls.Remove(itemout_uc1);
                itemout_uc1.Dispose();
                itemout_uc1 = null;
            }
        }

        // Ereignishandler für das Klicken auf den Button zum Hinzufügen eines neuen Benutzers
        // Event handler for clicking the add new user button
        void new_user_Click(object sender, EventArgs e)
        {
            user_Add_uc1 = new User_Add_UC();
            Controls.Add(user_Add_uc1);
            user_Add_uc1.BringToFront();

            // Schließt andere UserControls
            // Closes other user controls
            if (booklist_uc1 != null)
            {
                Controls.Remove(booklist_uc1);
                booklist_uc1.Dispose();
                booklist_uc1 = null;
            }

            if (book_Out_uc1 != null)
            {
                Controls.Remove(book_Out_uc1);
                book_Out_uc1.Dispose();
                book_Out_uc1 = null;
            }

            if (book_In_uc1 != null)
            {
                Controls.Remove(book_In_uc1);
                book_In_uc1.Dispose();
                book_In_uc1 = null;
            }

            if (userlist_uc1 != null)
            {
                Controls.Remove(userlist_uc1);
                userlist_uc1.Dispose();
                userlist_uc1 = null;
            }

            if (book_add_uc1 != null)
            {
                Controls.Remove(book_add_uc1);
                book_add_uc1.Dispose();
                book_add_uc1 = null;
            }

            if (book_Del_uc1 != null)
            {
                Controls.Remove(book_Del_uc1);
                book_Del_uc1.Dispose();
                book_Del_uc1 = null;
            }

            if (itemout_uc1 != null)
            {
                Controls.Remove(itemout_uc1);
                itemout_uc1.Dispose();
                itemout_uc1 = null;
            }
        }

        // Ereignishandler für das Klicken auf den Button zum Löschen eines Buches
        // Event handler for clicking the delete book button
        void book_delete_Click(object sender, EventArgs e)
        {
            book_Del_uc1 = new Item_Del_UC();
            Controls.Add(book_Del_uc1);
            book_Del_uc1.BringToFront();

            // Schließt andere UserControls
            // Closes other user controls
            if (booklist_uc1 != null)
            {
                Controls.Remove(booklist_uc1);
                booklist_uc1.Dispose();
                booklist_uc1 = null;
            }

            if (book_Out_uc1 != null)
            {
                Controls.Remove(book_Out_uc1);
                book_Out_uc1.Dispose();
                book_Out_uc1 = null;
            }

            if (book_In_uc1 != null)
            {
                Controls.Remove(book_In_uc1);
                book_In_uc1.Dispose();
                book_In_uc1 = null;
            }

            if (userlist_uc1 != null)
            {
                Controls.Remove(userlist_uc1);
                userlist_uc1.Dispose();
                userlist_uc1 = null;
            }

            if (book_add_uc1 != null)
            {
                Controls.Remove(book_add_uc1);
                book_add_uc1.Dispose();
                book_add_uc1 = null;
            }

            if (user_Add_uc1 != null)
            {
                Controls.Remove(user_Add_uc1);
                user_Add_uc1.Dispose();
                user_Add_uc1 = null;
            }

            if (itemout_uc1 != null)
            {
                Controls.Remove(itemout_uc1);
                itemout_uc1.Dispose();
                itemout_uc1 = null;
            }
        }

        // Ereignishandler für das Klicken auf den Button zur Anzeige der ausgeliehenen Artikel
        // Event handler for clicking the borrowed items list button
        private void itemout_list_Click(object sender, EventArgs e)
        {
            itemout_uc1 = new Itemout_UC();
            Controls.Add(itemout_uc1);
            itemout_uc1.BringToFront();

            // Schließt andere UserControls
            // Closes other user controls
            if (booklist_uc1 != null)
            {
                Controls.Remove(booklist_uc1);
                booklist_uc1.Dispose();
                booklist_uc1 = null;
            }

            if (book_Del_uc1 != null)
            {
                Controls.Remove(book_Del_uc1);
                book_Del_uc1.Dispose();
                book_Del_uc1 = null;
            }

            if (book_Out_uc1 != null)
            {
                Controls.Remove(book_Out_uc1);
                book_Out_uc1.Dispose();
                book_Out_uc1 = null;
            }

            if (book_In_uc1 != null)
            {
                Controls.Remove(book_In_uc1);
                book_In_uc1.Dispose();
                book_In_uc1 = null;
            }

            if (userlist_uc1 != null)
            {
                Controls.Remove(userlist_uc1);
                userlist_uc1.Dispose();
                userlist_uc1 = null;
            }

            if (book_add_uc1 != null)
            {
                Controls.Remove(book_add_uc1);
                book_add_uc1.Dispose();
                book_add_uc1 = null;
            }

            if (user_Add_uc1 != null)
            {
                Controls.Remove(user_Add_uc1);
                user_Add_uc1.Dispose();
                user_Add_uc1 = null;
            }
        }

        // Ereignishandler für das MouseEnter-Ereignis der Dogebox
        // Event handler for the MouseEnter event of the dogebox
        void dogebox_MouseEnter(object sender, EventArgs e)
        {
            dogebox.Image = Properties.Resources.doge;
        }

        // Ereignishandler für das MouseLeave-Ereignis der Dogebox
        // Event handler for the MouseLeave event of the dogebox
        void dogebox_MouseLeave(object sender, EventArgs e)
        {
            dogebox.Image = Properties.Resources.Transparent;
        }

        // Ermöglicht das Verschieben des Formulars durch Ziehen der Topbar
        // Allows moving the form by dragging the topbar
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        void Topbar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }

    public static class WindowExtension
    {
        [DllImport("user32.dll")]
        static internal extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

        // Aktiviert den Blur-Effekt für das Formular
        public static void EnableBlur(this Form @this)
        {
            // Erstellt eine neue Instanz der AccentPolicy-Struktur
            var accent = new AccentPolicy();
            // Setzt den AccentState auf ACCENT_ENABLE_BLURBEHIND, um den Blur-Effekt zu aktivieren
            accent.AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND;
            // Bestimmt die Größe der AccentPolicy-Struktur in Bytes
            var accentStructSize = Marshal.SizeOf(accent);
            // Reserviert einen Block von nicht verwaltetem Speicher der Größe der AccentPolicy-Struktur
            var accentPtr = Marshal.AllocHGlobal(accentStructSize);
            // Kopiert die Daten der AccentPolicy-Struktur in den reservierten nicht verwalteten Speicher
            Marshal.StructureToPtr(accent, accentPtr, false);
            // Erstellt eine neue Instanz der WindowCompositionAttributeData-Struktur
            var Data = new WindowCompositionAttributeData();
            // Setzt das Attribut auf WCA_ACCENT_POLICY, um die Akzent-Richtlinie zu ändern
            Data.Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY;
            // Setzt die Größe der Daten auf die Größe der AccentPolicy-Struktur
            Data.SizeOfData = accentStructSize;
            // Setzt den Datenzeiger auf den reservierten nicht verwalteten Speicher, der die AccentPolicy-Daten enthält
            Data.Data = accentPtr;
            // Ruft die SetWindowCompositionAttribute-Funktion auf, um die Fensterkompositionsattribute des Formulars zu ändern
            SetWindowCompositionAttribute(@this.Handle, ref Data);
            // Gibt den reservierten nicht verwalteten Speicher frei, um Speicherlecks zu vermeiden
            Marshal.FreeHGlobal(accentPtr);
        }
    }

    // Definiert den Zustand des Akzents für die Fenstereffekte
    enum AccentState
    {
        // Aktiviert den Blur-Effekt hinter dem Fenster
        ACCENT_ENABLE_BLURBEHIND = 3
    }

    // Struktur zur Definition der Akzent-Richtlinie für das Fenster
    struct AccentPolicy
    {
        // Der Zustand des Akzents (z.B. Blur-Effekt)
        public AccentState AccentState;
        // Flags für zusätzliche Akzentoptionen (nicht verwendet)
        //public int AccentFlags;
        // Farbe für den Akzentverlauf (nicht verwendet)
        //public int GradientColor;
        // ID für Animationen (nicht verwendet)
        //public int AnimationId;
    }

    // Struktur zur Definition der Fensterkompositionsattribute
    struct WindowCompositionAttributeData
    {
        // Das Attribut, das geändert werden soll (z.B. Akzent-Richtlinie)
        public WindowCompositionAttribute Attribute;
        // Zeiger auf die Daten der Akzent-Richtlinie
        public IntPtr Data;
        // Größe der Datenstruktur
        public int SizeOfData;
    }

    // Definiert die verschiedenen Fensterkompositionsattribute
    enum WindowCompositionAttribute
    {
        // Attribut für die Akzent-Richtlinie
        WCA_ACCENT_POLICY = 19
    }
}
