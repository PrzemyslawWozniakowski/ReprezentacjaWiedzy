using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicExpressionsParser;

namespace RWLogic
{
    public class Formula // reprezentuje takie wyrazeania jak a OR b, a AND b, IF a THEN b
    {

        private LogicalExpressionRoot LogicalExpressionRoot;
        private bool EmptyRoot = false;
        private string[] FluentNames;
        public Formula(LogicalExpressionRoot root, string[] fluentName)
        {
            LogicalExpressionRoot = root;
            FluentNames = fluentName;
        }
        public Formula()
        {
            LogicalExpressionRoot = null;
            EmptyRoot = true;
        }
        //Nie wiem czy co� z tego b�dzie potrzebne, wi�c p�ki co zostawiam
        //private (int id, bool value) fluent1;
        //private (int id, bool value) fluent2;
        //private symbol op = symbol.NULL;

        //public enum symbol
        //{
        //    NULL = -1,
        //    OR = 0,
        //    AND = 1,
        //    THEN = 2
        //}

        //private bool specialTreatmentFlag; // traktujemy wartosc warunku jako zawsze true albo zawsze false
        //private bool specialValue; // tutaj ta wartosc

        //public Formula((int, bool) fluent1) // warunek typu A causes alfa if fluent1
        //{
        //    specialTreatmentFlag = false;
        //    this.fluent1 = fluent1;
        //    this.fluent2 = (0, true);
        //    this.op = symbol.NULL;
        //}  

        //public Formula((int, bool) fluent1, (int, bool) fluent2, symbol op) // warunek typu A casues alfa if fluent1 AND fluent2 itd.
        //{
        //    specialTreatmentFlag = false;
        //    this.fluent1 = fluent1;
        //    this.fluent2 = fluent2;
        //    this.op = op;
        //}

        //public Formula(bool value) // warunek typu A causes alfa if true
        //{
        //    this.specialTreatmentFlag = true;
        //    this.specialValue = value;
        //}

        //public Formula() // warunek typu brak warunku, czyli np. A causes alfa
        //{
        //    this.specialTreatmentFlag = true;
        //    this.specialValue = true;
        //}

        public bool CheckCondition(Model.State state)
        {
            throw new NotImplementedException();
            //if (specialTreatmentFlag) return specialValue;
            //switch (op)
            //{
            //    case symbol.NULL:
            //        {
            //            return state.fluents[fluent1.id] == fluent1.value;
            //        }
            //    case symbol.OR:
            //        {
            //            return state.fluents[fluent1.id] == fluent1.value || state.fluents[fluent2.id] == fluent2.value;
            //        }
            //    case symbol.AND:
            //        {
            //            return state.fluents[fluent1.id] == fluent1.value && state.fluents[fluent2.id] == fluent2.value;
            //        }
            //    case symbol.THEN:
            //        {
            //            return !state.fluents[fluent1.id] == fluent1.value || state.fluents[fluent2.id] == fluent2.value;
            //        }
            //}
            //return false;
        }

    }
}
