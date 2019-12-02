using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_ClientApp2
{
    /// <summary>
    /// monster entity class
    /// </summary>
    public class Monster
    {
        public enum EmotionalState
        {
            happy,
            sad,
            angry,
            bored
        }

        public enum Tribe
        {            
            Uru,
            Gortha,
            Yonvul,
            Roko,
        }

        #region FIELDS

        private string _name;
        private int _age;
        private EmotionalState _attitude;
        private Tribe _TribeAFL;
        private bool _isActive;

        #endregion

        #region PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public EmotionalState Attitude
        {
            get { return _attitude; }
            set { _attitude = value; }
        }

        public Tribe TribeAFL
        {
            get { return _TribeAFL; }
            set { _TribeAFL = value; }
        }

        public bool isActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
        #endregion

        #region CONSTRUCTORS

        public Monster()
        {

        }

        public Monster(string name, int age, EmotionalState attitude)
        {
            _name = name;
            _age = age;
            _attitude = attitude;
            _TribeAFL = TribeAFL;
            _isActive = isActive;
        }

        #endregion
        
        #region METHODS

        public string Greeting()
        {
            string greeting;

            switch (_attitude)
            {
                case EmotionalState.happy:
                    greeting = $"Hello, my name is {_name} and I am having a great day!";
                    break;

                case EmotionalState.sad:
                    greeting = $"{_name} is feeling bad.";
                    break;

                case EmotionalState.angry:
                    greeting = $"I'm {_name}, and stay away from me!";
                    break;

                case EmotionalState.bored:
                    greeting = $"I don't know what to do at {_age} years old.";
                    break;

                default:
                    greeting = $"Hello, my name is {_name}.";
                    break;
            }
                       
            return greeting;
        }

        public string TribeChant()
        {
            string tribeChant;
            switch (_TribeAFL)
            {          
                case Tribe.Uru:
                    tribeChant = $"{_name} from {_TribeAFL} tribe will crush you! We are the tribe of WAR!";
                    break;

                case Tribe.Gortha:
                    tribeChant = $"I, {_name} from {_TribeAFL} will Enlighten you, for we are the tribe of wisdom.";
                    break;

                case Tribe.Yonvul:
                    tribeChant = $"{_name} from {_TribeAFL} will amaze you with its technology. we are the tribe of technology.";
                    break;

                case Tribe.Roko:
                    tribeChant = $"{_name} from {_TribeAFL} will preach to you. We are the tribe of Theology.";
                    break;

                default:
                    tribeChant = $"{_name} wishes he was a part of a tribe.";
                    break;
            }

            return tribeChant;
        }
        #endregion
    }
}
