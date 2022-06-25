double speed_1_friend = 1;
double speed_2_friend = 2;
double speed_dog = 5;
double time = 0;

int friend = 2;
double dist = 10000;
int times_the_dog_run = 0;

while (dist >= 10)
{
    if (friend == 1) {
        time = dist / (speed_dog + speed_2_friend);
        friend = 2;
    }

    if (friend == 2)  {
        time = dist / (speed_dog + speed_1_friend);
        friend = 1;
    }
    dist = dist - (speed_1_friend + speed_2_friend) * time;
    times_the_dog_run++;
}

Console.WriteLine(times_the_dog_run);
