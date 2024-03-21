namespace MyGame
{
    public class Enemy
    { 
        private string name;
        private float shield;
        private float health;

        public Enemy(string name, float shield, float health)
        {
        
            this.name = name;
            this.shield = shield;
            this.health = health;
        }

        //Método para obter o nome do inimigo
        public string GetName()
        {
            return name;
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