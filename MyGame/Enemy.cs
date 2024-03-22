namespace MyGame
{
    public class Enemy
    { 
        private string name;
        private float shield;
        private float health;

        public Enemy(string name, float shield, float health)
        {
        
            SetName(name);
            this.shield = shield;
            this.health = health;
        }

        //Método para obter o nome do inimigo
        public string GetName()
        {
            return name;
        }

        //Método para alterar o nome do inimigo
        public void SetName(string newName)
        {
            if (newName.Length > 8)
            {
                name = newName.Substring (0,8);
            }
            else
            {
                name = newName;
            }
        }

        //Método para obter saúde do inimigo
        public float GetHealth()
        {
            return health;
        }

        //Método para obter escudo do inimigo
        public float GetShield()
        {
            return shield;
        }

        //Método para aplicar dano ao inimigo
        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health <0)
                health = 0;
            }
    
        }
    }
}