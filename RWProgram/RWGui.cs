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
using RWProgram.Enums;
namespace RWProgram
{
    public partial class RWGui : Form
    {
        public StatementEnum statementWIP = StatementEnum.None;
         
        public List<string> Statements = new List<string>()
        {
            "initially alfa",
            "alfa after A_1 by w_1, A_2 by w_2, ... ,A_n by w_n",
            "alfa typically after A_1 by w_1, A_2 by w_2, ... ,A_n by w_n",
            "observable alfa after A_1 by w_1, A_2 by w_2, ... ,A_n by w_n",
            "A by w causes alfa if pi",
            "A by w releases f if pi",
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
            StatementsComboBox.Items.AddRange(Statements.ToArray());
        }

        private void ActorsTextBox_Changed(object sender, EventArgs e)
        {
            var actors_names = actorsTextBox.Text.Split(',',';','\n');
            actors_names = actors_names.Select(a => a.Trim()).Where(a => a != String.Empty).ToArray();

            var to_create = actors_names.Where(a => !Logic.Actors.Any(x => x.Name == a));
            Logic.Actors = Logic.Actors.Where(x => actors_names.Any(a => a == x.Name)).ToList();
            foreach (var a in to_create)
                Logic.Actors.Add(new Actor() { Name = a });
            actorComboBox.Items.Clear();
            actorComboBox.Items.AddRange(Logic.Actors.ToArray());
            ProgramActorComboBox.Items.Clear();
            ProgramActorComboBox.Items.AddRange(Logic.Actors.ToArray());
        }

        private void FluentsTextBox_Changed(object sender, EventArgs e)
        {
            var fluents_names = fluentsTextBox.Text.Split(',', ';', '\n');
            fluents_names = fluents_names.Select(f => f.Trim()).Where(f => f != String.Empty).ToArray();

            var to_create = fluents_names.Where(f => !Logic.Fluents.Any(x => x.Name == f));
            Logic.Fluents = Logic.Fluents.Where(x => fluents_names.Any(f => f == x.Name)).ToList();
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
            actions_names = actions_names.Select(a => a.Trim()).Where(a => a != String.Empty).ToArray();

            var to_create = actions_names.Where(a => !Logic.Actions.Any(x => x.Name == a));
            Logic.Actions = Logic.Actions.Where(x => actions_names.Any(a => a == x.Name)).ToList();
            foreach (var f in to_create)
                Logic.Actions.Add(new Action() { Name = f });
            actionComboBox.Items.Clear();
            actionComboBox.Items.AddRange(Logic.Actions.ToArray());
            ProgramActionComboBox.Items.Clear();
            ProgramActionComboBox.Items.AddRange(Logic.Actions.ToArray());
        }

        private void ClickAddStatementButton(object sender, EventArgs e)
        {
            var index = StatementsComboBox.SelectedIndex;
            StatementEnum statementEnum = (StatementEnum)index;
            switch (statementEnum)
            {
                case StatementEnum.InitiallyFluent:
                    Logic.Statements.Add(new InitiallyFluent ((Fluent)fluentComboBox.SelectedItem));
                    break;
                case StatementEnum.FluentAfterActionbyActor:
                    statementWIP = StatementEnum.FluentAfterActionbyActor;
                    Logic.Statements.Add(new FluentAfterActionbyActor
                    (
                        (Fluent)fluentComboBox.SelectedItem,
                        new List<Action> { (Action)actionComboBox.SelectedItem },
                        new List<Actor> { (Actor)actorComboBox.SelectedItem }
                    ));
                    break;
                case StatementEnum.FluentTypicallyAfterActionbyActor:
                    statementWIP = StatementEnum.FluentTypicallyAfterActionbyActor;
                    Logic.Statements.Add(new FluentTypicallyAfterActionbyActor
                    (
                        (Fluent)fluentComboBox.SelectedItem,
                        new List<Action> { (Action)actionComboBox.SelectedItem },
                        new List<Actor> { (Actor)actorComboBox.SelectedItem }
                    ));
                    break;
                case StatementEnum.ObservableFluentAfterActionByActor:
                    statementWIP = StatementEnum.ObservableFluentAfterActionByActor;
                    Logic.Statements.Add(new ObservableFluentAfterActionByActor
                    (
                        (Fluent)fluentComboBox.SelectedItem,
                        new List<Action> { (Action)actionComboBox.SelectedItem },
                        new List<Actor> { (Actor)actorComboBox.SelectedItem }
                    ));
                    break;
                case StatementEnum.ActionByActorCausesAlphaIfFluents:
                    statementWIP = StatementEnum.ActionByActorCausesAlphaIfFluents;
                    Logic.Statements.Add(new ActionByActorCausesAlphaIfFluents
                    (
                        (Fluent)fluentComboBox.SelectedItem,
                        (Action)actionComboBox.SelectedItem,
                        (Actor)actorComboBox.SelectedItem,
                        new List<Fluent> { (Fluent)piComboBox.SelectedItem }
                    ));
                    break;
                case StatementEnum.ActionByActorReleasesFluent1IfFluents:
                    statementWIP = StatementEnum.ActionByActorReleasesFluent1IfFluents;
                    Logic.Statements.Add(new ActionByActorReleasesFluent1IfFluents
                    (
                        (Fluent)fluentComboBox.SelectedItem,
                        (Action)actionComboBox.SelectedItem,
                        (Actor)actorComboBox.SelectedItem,
                        new List<Fluent> { (Fluent)piComboBox.SelectedItem }
                    ));
                    break;
                case StatementEnum.ActionByActorTypicallyCausesAlphaIfFluents:
                    statementWIP = StatementEnum.ActionByActorTypicallyCausesAlphaIfFluents;
                    Logic.Statements.Add(new ActionByActorTypicallyCausesAlphaIfFluents
                    (
                        (Fluent)fluentComboBox.SelectedItem,
                        (Action)actionComboBox.SelectedItem,
                        (Actor)actorComboBox.SelectedItem,
                        new List<Fluent> { (Fluent)piComboBox.SelectedItem }
                    ));
                    break;
                case StatementEnum.ActionByActorTypicallyReleasesFluent1IfFluents:
                    statementWIP = StatementEnum.ActionByActorTypicallyReleasesFluent1IfFluents;
                    Logic.Statements.Add(new ActionByActorTypicallyReleasesFluent1IfFluents
                    (
                        (Fluent)fluentComboBox.SelectedItem,
                        (Action)actionComboBox.SelectedItem,
                        (Actor)actorComboBox.SelectedItem,
                        new List<Fluent> { (Fluent)piComboBox.SelectedItem }
                    ));
                    break;
                case StatementEnum.ImpossibleActionByActorIfFluents:
                    statementWIP = StatementEnum.ImpossibleActionByActorIfFluents;
                    Logic.Statements.Add(new ImpossibleActionByActorIfFluents
                    (
                        (Action)actionComboBox.SelectedItem,
                        (Actor)actorComboBox.SelectedItem,
                        new List<Fluent> { (Fluent)piComboBox.SelectedItem }
                    ));
                    break;
                case StatementEnum.AlwaysPi:
                    statementWIP = StatementEnum.AlwaysPi;
                    Logic.Statements.Add(new AlwaysPi
                    (
                        new List<Fluent> { (Fluent)piComboBox.SelectedItem }
                    ));
                    break;
                case StatementEnum.NoninertialFluent:
                    Logic.Statements.Add(new NoninertialFluent
                    (
                        (Fluent)fluentComboBox.SelectedItem
                    ));
                    break;
                default:
                    break;
            }

            if (statementWIP != StatementEnum.InitiallyFluent && statementWIP != StatementEnum.NoninertialFluent && statementWIP != StatementEnum.None)
                ShowButtons();

            setStatementsText();
        }

        private void AddToProgramButton_Click(object sender, EventArgs e)
        {
            Logic.Program.Add(((Action)ProgramActionComboBox.SelectedItem, (Actor)ProgramActorComboBox.SelectedItem));
            setProgramText();
        }

        private void setStatementsText()
        {
            var str = string.Empty;
            foreach (var st in Logic.Statements)
                str = str + st.ToString() + "\n";

            StatementsTextBox.Text = str;
        }

        private void setProgramText()
        {
            var str = string.Empty;
            foreach (var p in Logic.Program)
                str = str + p.Item1.ToString() + " by " + p.Item2.ToString() + "\n";
            richTextBox2.Text = str;
        }

        private void ResetStatementsButton_Click(object sender, EventArgs e)
        {
            Logic.Statements = new List<Statement>();
            setStatementsText();
            resetComboBoxes();
        }

        private void resetComboBoxes()
        {
            actionComboBox.SelectedIndex = -1;
            actorComboBox.SelectedIndex = -1;
            piComboBox.SelectedIndex = -1;
            fluentComboBox.SelectedIndex = -1;
        }

        private void StatementsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            statementWIP = StatementEnum.None;
            resetComboBoxes();
            setStatementsText();
        }

        private void ConfirmStatementButton_Click(object sender, EventArgs e)
        {
            HideButtons();
        }

        private void ResetProgramButton_Click(object sender, EventArgs e)
        {
            Logic.Program = new List<(Classes.Action, Actor)>();
            setProgramText();
        }

        private void AddConditionButton_Click(object sender, EventArgs e)
        {
            switch (statementWIP)
            {
                case StatementEnum.FluentAfterActionbyActor:
                case StatementEnum.ObservableFluentAfterActionByActor:
                case StatementEnum.FluentTypicallyAfterActionbyActor:
                    {
                        var statement = Logic.Statements.Last();
                        var afterActionByActor = statement as StatementAfterActionByUser;
                        if (afterActionByActor != null)
                        {
                            afterActionByActor.Actions.Add((Action)actionComboBox.SelectedItem);
                            afterActionByActor.Actors.Add((Actor)actorComboBox.SelectedItem);
                        }
                        break;
                    }
                case StatementEnum.ActionByActorCausesAlphaIfFluents:
                case StatementEnum.ActionByActorReleasesFluent1IfFluents:
                case StatementEnum.ActionByActorTypicallyCausesAlphaIfFluents:
                case StatementEnum.ActionByActorTypicallyReleasesFluent1IfFluents:
                case StatementEnum.ImpossibleActionByActorIfFluents:
                case StatementEnum.AlwaysPi:
                    {
                        var statement = Logic.Statements.Last();
                        var conditionStatement = statement as ConditionStatement;
                        if (conditionStatement != null)
                        {
                            conditionStatement.Pi.Add((Fluent)piComboBox.SelectedItem);
                        }
                        break;
                    }
                default:
                    break;
            }
            setStatementsText();
        }

        private void ShowButtons()
        {
            ConfirmStatementButton.Visible = true;
            ConfirmStatementButton.Enabled = true;
            AddConditionButton.Visible = true;
            AddConditionButton.Enabled = true; 
        }

        private void HideButtons()
        {
            ConfirmStatementButton.Visible = false;
            ConfirmStatementButton.Enabled = false;
            AddConditionButton.Visible = false;
            AddConditionButton.Enabled = false;
        }
    }
}
