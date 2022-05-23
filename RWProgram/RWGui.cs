using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RWProgram.Classes;
using Action = RWProgram.Classes.Action;

namespace RWProgram
{
    public partial class RWGui : Form
    {
        public List<string> Statements = new List<string>()
        {
            "initially alfa",
            "alfa after A_1 by w_1, A_2 by w_2, ... ,A_n by w_n",
            "alfa typically after A_1 by w_1, A_2 by w_2, ... ,A_n by w_n",
            "observable alfa after A_1 by w_1, A_2 by w_2, ... ,A_n by w_n",
            "A by w causes alfa if pi",
            "A by releases f if pi",
            "A by w typically causes alfa if pi",
            "A by w typically release f if pi",
            "impossible A by w if pi",
            "always pi",
            "noninertial fluent"
        };
        public RWLogic Logic { get; set; }
        public RWGui()
        {
            InitializeComponent();
            Logic = new RWLogic();
            statementsComboBox.Items.AddRange(Statements.ToArray());
        }

        private void ActorsTextBox_Changed(object sender, EventArgs e)
        {
            var actors_names = actorsTextBox.Text.Split(',',';','\n');
            var to_create = actors_names.Where(a => !Logic.Actors.Any(x => x.Name == a));
            Logic.Actors = Logic.Actors.Where(x => actors_names.Any(a => a == x.Name)).ToList();
            foreach (var a in to_create)
                Logic.Actors.Add(new Actor() { Name = a });
            actorComboBox.Items.Clear();
            actorComboBox.Items.AddRange(Logic.Actors.ToArray());
            programActorComboBox.Items.Clear();
            programActorComboBox.Items.AddRange(Logic.Actors.ToArray());
        }

        private void FluentsTextBox_Changed(object sender, EventArgs e)
        {
            var fluents_names = fluentsTextBox.Text.Split(',', ';', '\n');
            var to_create = fluents_names.Where(a => !Logic.Fluents.Any(x => x.Name == a));
            Logic.Fluents = Logic.Fluents.Where(x => fluents_names.Any(a => a == x.Name)).ToList();
            foreach (var f in to_create)
            {
                var fluent = new Fluent() { Name = f };
                Logic.Fluents.Add(fluent);
                Logic.Fluents.Add(new NegatedFluent() { Name = f, Original = fluent });
            }
            fluentComboBox.Items.Clear();
            fluentComboBox.Items.AddRange(Logic.Fluents.ToArray());

            piComboBox.Items.Clear();
            piComboBox.Items.AddRange(Logic.Fluents.ToArray());
        }

        private void ActionsTextBox_Changed(object sender, EventArgs e)
        {
            var actions_names = actionsTextBox.Text.Split(',', ';', '\n');
            var to_create = actions_names.Where(a => !Logic.Actions.Any(x => x.Name == a));
            Logic.Actions = Logic.Actions.Where(x => actions_names.Any(a => a == x.Name)).ToList();
            foreach (var f in to_create)
                Logic.Actions.Add(new Action() { Name = f });
            actionComboBox.Items.Clear();
            actionComboBox.Items.AddRange(Logic.Actions.ToArray());
            programActionComboBox.Items.Clear();
            programActionComboBox.Items.AddRange(Logic.Actions.ToArray());
        }

        private void ClickAddStatementButton(object sender, EventArgs e)
        {
            var index = statementsComboBox.SelectedIndex;
            switch (index)
            {
                case 0:
                    Logic.Statements.Add(new InitiallyFluent {Alpha = (Fluent)fluentComboBox.SelectedItem});
                    break;
                case 1:
                    break;
                case 4:
                    Logic.Statements.Add(new ActionByActorCausesAlphaIfFluent 
                    { 
                        Alpha = (Fluent)fluentComboBox.SelectedItem, 
                        Action = (Action)actionComboBox.SelectedItem,
                        Actor = (Actor)actorComboBox.SelectedItem,
                        Pi = new List<Fluent> { (Fluent)piComboBox.SelectedItem }
                    });
                    break;
                default:
                    break;
            }

            var str = string.Empty;
            foreach(var st in Logic.Statements)
                str = str + st.ToString() + "\n";

            richTextBox1.Text = str;
        }

        private void AddToProgramButton_Click(object sender, EventArgs e)
        {
            Logic.Program.Add(((Action)programActionComboBox.SelectedItem, (Actor)programActorComboBox.SelectedItem));
            var str = string.Empty;
            foreach (var p in Logic.Program)
                str = str + p.Item1.ToString() + " by " + p.Item2.ToString() + "\n";
            richTextBox2.Text = str;
        }
    }
}
