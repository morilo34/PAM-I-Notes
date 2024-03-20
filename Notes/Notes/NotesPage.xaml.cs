namespace Notes;

public partial class NotesPage : ContentPage
{
    string path = Path.Combine(FileSystem.AppDataDirectory,"data.txt");
    string text = "";
	public NotesPage()
	{
		InitializeComponent();
        if (File.Exists(path))
        {
            FileEditor.Text = File.ReadAllText(path);
        }
    }

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        //Pegar o texto escrito no editor de texto
        //Armazenar esse arquivo em uma variavel
        //Criar um arquivo com esse conteúdo
        text = FileEditor.Text;

        FilePicker.PickAsync();
        File.WriteAllText(path, text);
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        text = FileEditor.Text;
        
    }
}