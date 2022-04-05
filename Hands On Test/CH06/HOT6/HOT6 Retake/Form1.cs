namespace HOT6_Retake
{
    public partial class Form1 : Form
    {
        string[] pokemon = new string[6]
        {
            "Pikachu",
            "Butterfree",
            "Pidgeotto",
            "Bulbasaur",
            "Charmander",
            "Squirtle"
        };
        string[] pokemonType = new string[6]
        {
            "Electric",
            "Bug",
            "Flying",
            "Grass",
            "Fire",
            "Water"
        };
        int[] pokedexNumber = new int[6]
        {
            025,
            012,
            017,
            001,
            004,
            007
        };
        string[] description = new string[6]
        {
            "The Mouse Pokemon. It can generate electric attacks from the electric pouches located in both of its cheeks.",
            "The Butterfly Pokemon. It's love of flower nectar drows it to seek out flowers, even if they don't have much pollen.",
            "The Bird Pokemon. It is armed with sharp claws and dives from the sky to capture it's prey. Unlike the more gentle Pidgey, it can be dangerous. Approach with extreme caution.",
            "It bears the seed of a plant on it's back from birth. The seed slowly develops. Researchers are unsure whether to classify them as plants or animals. They are extremely tough and very difficult to capture in the wild.",
            "A flame burns on the tip of it's tail from birth. It is said that a Charmander dies if it's flame ever goes out.",
            "This Tiny Turtle Pokemon draws it's long neck into it's shell to launch an incredible water attack with amazing range and accuracy. The blasts can be quite powerful."
        };
        string errorMsg = "Pokemon not found";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTypeSearch_Click(object sender, EventArgs e)
        {
            string pokemonType = txtTypeBox.Text;
            ShowPokemon();
            SearchByType(pokemonType);
        }

        private void btnNumSearch_Click(object sender, EventArgs e)
        {
            int pokedexNum = Convert.ToInt32(txtNumBox.Text);
            ShowPokemon(pokedexNum);
            SearchByPokedexNumber(pokedexNum);
        }

        private void btnKeywordSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtKeywordBox.Text;
            ShowPokemon();
            SearchByKeyword(keyword);
        }
        private int SearchByType(string type)
        {
            int searchPosition = -1;
            for (int i = 0; i < pokemonType.Length; i++)
            {
                if (type.ToLower().Contains(pokemonType[i].ToLower()))
                {
                    searchPosition =i;
                }
                else
                {
                    lblPokemon.Text = errorMsg;
                    lblEntryDetail.Text = errorMsg;
                    lblType.Text = errorMsg;
                    lblPokedexNum.Text = errorMsg;
                }
            }
            return searchPosition;
        }
        private int SearchByPokedexNumber(int num)
        {
            for (int i = 0; i < pokedexNumber.Length; i++)
            {
                if (num == pokedexNumber[i])
                {
                    return i;
                }
                else
                {
                    lblPokemon.Text = errorMsg;
                    lblEntryDetail.Text = errorMsg;
                    lblType.Text = errorMsg;
                    lblPokedexNum.Text = errorMsg;
                }
            }
        }
        private string SearchByKeyword(string keyword)
        {
            for (int i = 0;i < keyword.Length; i++)
            {
                if (keyword.ToLower().Contains(description[i].ToLower()))
                {
                    return i;
                }
                else 
                {
                    lblPokemon.Text = errorMsg;
                    lblEntryDetail.Text = errorMsg;
                    lblType.Text = errorMsg;
                    lblPokedexNum.Text = errorMsg;
                }
            }
            
        }
        private string ShowPokemon(string[] pokemon, string[] pokemonType,int pokedexNumber, string[] description )
        {
            if (SearchByType() == true || SearchByPokedexNumber() == true || SearchByKeyword() == true)
            {
                lblPokemon.Text = String.Format("{0}", pokemon[i]);
                lblEntryDetail.Text = String.Format("{0}", description[i]);
                lblType.Text = String.Format("{0}", pokemonType[i]);
                lblPokedexNum.Text = String.Format("{0}", pokedexNumber[i]);
            }

        }
    }
}