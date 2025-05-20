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
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Resize += Dashboard_Form_Resize;
        }

        private void Dashboard_Form_Resize(object sender, EventArgs e)
        {
            // Example of manually resizing and repositioning controls
            // Adjust the size and position of controls as needed
            // For example:
            // button1.Width = this.ClientSize.Width / 2;
            // button1.Height = this.ClientSize.Height / 10;
            // button1.Location = new Point(this.ClientSize.Width / 4, this.ClientSize.Height / 2 - button1.Height / 2);

            // Adjust user controls
            foreach (Control control in this.Controls)
            {
                if (control is UserControl)
                {
                    control.Width = this.ClientSize.Width - 20; // Example adjustment
                    control.Height = this.ClientSize.Height - 20; // Example adjustment
                }
            }
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
            guna2ShadowForm1.SetShadowForm(this);

            // Aktiviert den Blur-Effekt
            this.EnableBlur();
            TransparencyKey = Color.LimeGreen;
            Close_all_UC();
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
            Close_all_UC();

            booklist_uc1 = new Itemlist_UC();
            Controls.Add(booklist_uc1);
            booklist_uc1.BringToFront();
        }

        // Ereignishandler für das Klicken auf den Ausleih-Button
        // Event handler for clicking the borrow button
        void Ausleih_button_Click(object sender, EventArgs e)
        {
            Close_all_UC();

            book_Out_uc1 = new Item_Out_UC();
            Controls.Add(book_Out_uc1);
            book_Out_uc1.BringToFront();
        }

        // Ereignishandler für das Klicken auf den Rückgabe-Button
        // Event handler for clicking the return button
        void Rueckgabe_button_Click(object sender, EventArgs e)
        {
            Close_all_UC();

            book_In_uc1 = new Item_In_UC();
            Controls.Add(book_In_uc1);
            book_In_uc1.BringToFront();

        }

        // Ereignishandler für das Klicken auf die Benutzerliste
        // Event handler for clicking the user list
        void User_list_Click(object sender, EventArgs e)
        {
            Close_all_UC();

            userlist_uc1 = new Userlist_UC();
            Controls.Add(userlist_uc1);
            userlist_uc1.BringToFront();
        }

        // Ereignishandler für das Klicken auf den Button zum Hinzufügen eines neuen Buches
        // Event handler for clicking the add new book button
        void book_add_new_Click(object sender, EventArgs e)
        {
            Close_all_UC();

            book_add_uc1 = new Item_add_UC();
            Controls.Add(book_add_uc1);
            book_add_uc1.BringToFront();
        }

        // Ereignishandler für das Klicken auf den Button zum Hinzufügen eines neuen Benutzers
        // Event handler for clicking the add new user button
        void new_user_Click(object sender, EventArgs e)
        {
            Close_all_UC();

            user_Add_uc1 = new User_Add_UC();
            Controls.Add(user_Add_uc1);
            user_Add_uc1.BringToFront();


        }

        // Ereignishandler für das Klicken auf den Button zum Löschen eines Buches
        // Event handler for clicking the delete book button
        void book_delete_Click(object sender, EventArgs e)
        {
            Close_all_UC();

            book_Del_uc1 = new Item_Del_UC();
            Controls.Add(book_Del_uc1);
            book_Del_uc1.BringToFront();

        }

        // Ereignishandler für das Klicken auf den Button zur Anzeige der ausgeliehenen Artikel
        // Event handler for clicking the borrowed items list button
        private void itemout_list_Click(object sender, EventArgs e)
        {
            Close_all_UC();

            itemout_uc1 = new Itemout_UC();
            Controls.Add(itemout_uc1);
            itemout_uc1.BringToFront();
        }

        public void Close_all_UC()
        {
            // Entfernt und bereinigt alle UserControls beim Laden
            if (itemout_uc1 != null)
            {
                Controls.Remove(itemout_uc1);
                itemout_uc1.Dispose();
                itemout_uc1 = null;
            }

            if (booklist_uc1 != null)
            {
                Controls.Remove(booklist_uc1);
                booklist_uc1.Dispose();
                booklist_uc1 = null;
            }

            if (book_add_uc1 != null)
            {
                Controls.Remove(book_add_uc1);
                book_add_uc1.Dispose();
                book_add_uc1 = null;
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

        //user32.dll ist eine Windows-Bibliothek, die grundlegende Funktionen für die Benutzeroberfläche und die Interaktion mit dem Betriebssystem bereitstellt.
        //Sie enthält Funktionen zur Fensterverwaltung, Nachrichtenverarbeitung und Benutzereingaben.
        //Diese Bibliothek ermöglicht es Anwendungen, mit dem Windows-Betriebssystem zu kommunizieren und verschiedene GUI-Operationen durchzuführen.
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
    // Erweiterungsklasse für Fenster
    // Extension class for windows
    public static class WindowExtension
    {
        // Importiert die SetWindowCompositionAttribute-Funktion aus der user32.dll
        // Imports the SetWindowCompositionAttribute function from user32.dll
        [DllImport("user32.dll")]
        static internal extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

        // Aktiviert den Blur-Effekt für das Formular
        // Enables the blur effect for the form
        public static void EnableBlur(this Form @this)
        {
            // Erstellt eine neue Akzent-Richtlinie mit dem Blur-Effekt
            // Creates a new accent policy with the blur effect
            var accent = new AccentPolicy
            {
                AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND
            };
            // Bestimmt die Größe der Akzent-Richtlinie-Struktur
            // Determines the size of the accent policy structure
            var accentStructSize = Marshal.SizeOf(accent);
            // Reserviert Speicherplatz für die Akzent-Richtlinie-Struktur
            // Allocates memory for the accent policy structure
            var accentPtr = Marshal.AllocHGlobal(accentStructSize);
            // Kopiert die Akzent-Richtlinie-Struktur in den reservierten Speicher
            // Copies the accent policy structure to the allocated memory
            Marshal.StructureToPtr(accent, accentPtr, false);

            // Erstellt eine neue Fensterkompositionsattribut-Datenstruktur
            // Creates a new window composition attribute data structure
            var Data = new WindowCompositionAttributeData
            {
                Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY,
                SizeOfData = accentStructSize,
                Data = accentPtr
            };

            // Setzt das Fensterkompositionsattribut für das Formular
            // Sets the window composition attribute for the form
            SetWindowCompositionAttribute(@this.Handle, ref Data);
            // Gibt den reservierten Speicher wieder frei
            // Frees the allocated memory
            Marshal.FreeHGlobal(accentPtr);
        }
    }

    // Definiert den Zustand des Akzents für die Fenstereffekte
    // Defines the accent state for window effects
    enum AccentState
    {
        // Aktiviert den Blur-Effekt hinter dem Fenster
        // Enables the blur effect behind the window
        ACCENT_ENABLE_BLURBEHIND = 3
    }

    // Struktur zur Definition der Akzent-Richtlinie für das Fenster
    // Structure to define the accent policy for the window
    struct AccentPolicy
    {
        // Der Zustand des Akzents (z.B. Blur-Effekt)
        // The state of the accent (e.g., blur effect)
        public AccentState AccentState;
        // Flags für zusätzliche Akzentoptionen
        // Flags for additional accent options
        public int AccentFlags;
        // Farbe für den Akzentverlauf
        // Color for the accent gradient
        public int GradientColor;
        // ID für Animationen
        // ID for animations
        public int AnimationId;
    }

    // Struktur zur Definition der Fensterkompositionsattribute
    // Structure to define the window composition attributes
    struct WindowCompositionAttributeData
    {
        // Das Attribut, das geändert werden soll (z.B. Akzent-Richtlinie)
        // The attribute to be changed (e.g., accent policy)
        public WindowCompositionAttribute Attribute;
        // Zeiger auf die Daten der Akzent-Richtlinie
        // Pointer to the accent policy data
        public IntPtr Data;
        // Größe der Datenstruktur
        // Size of the data structure
        public int SizeOfData;
    }

    // Definiert die verschiedenen Fensterkompositionsattribute
    // Defines the various window composition attributes
    enum WindowCompositionAttribute
    {
        // Attribut für die Akzent-Richtlinie
        // Attribute for the accent policy
        WCA_ACCENT_POLICY = 19
    }
}
