public class Unit
{
    //Charactersitics
    public int Agility { get; set; }
    public int Intellect { get; set; }
    public int Power { get; set; }
    public int Physique { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }

    //Skills
    public int Acrobatics { get; set; }
    public int Athletics { get; set; }
    public int Magic { get; set; }
    public int Deception { get; set; }
    public int Story { get; set; }
    public int Insight { get; set; }
    public int Intimidation { get; set; }
    public int Investigation { get; set; }
    public int Medicine { get; set; }
    public int Nature { get; set; }
    public int Perception { get; set; }
    public int Performance { get; set; }
    public int Belief { get; set; }
    public int Religion { get; set; }
    public int Sleight_of_hand { get; set; }
    public int Secrecy { get; set; }
    public int Survival { get; set; }
    public int Animal_handling { get; set; }

    //Класс брони
    public int Armor { get; set; }

    //Инициатива
    public int Initiative { get; set; }

    //Скорость
    public int Speed { get; set; }

    //Здоровье 
    public int Сurrent_Health { get; set; }
    public int Temporary_Health { get; set; }
    
    virtual public void Move()
    {

    }
    virtual public void Attack()
    {

    }

}

