EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL CharAnimation(charName, animationName)
EXTERNAL ChangeTime(timeLeft)
EXTERNAL ShowArgue(argueStatus)
EXTERNAL ChangeScript(scriptName)
EXTERNAL TransNum(transNumber)

{ChangeTime(0)}
Test

{Name("Farah")}
{Icon("farah")}
{CharAnimation("haru_greeter_t03","Agree")}
{ChangeTime(5)}
Memang benar para pelajar yang cenderung kurang berani mengemukakan pendapat

{CharAnimation("haru_greeter_t03","Agree")}
{ChangeTime(3)}
Akan dapat membangun kepercayaan diri di media sosial.

{ChangeTime(3)}
Akan tetapi, hanya dalam lingkup media sosial.

{CharAnimation("haru_greeter_t03","GivingArgument")}
{ChangeTime(4)}
Sedangkan kita hidup di dunia nyata. Lalu, buat apa itu semua?

{ShowArgue(true)}
{TransNum(2)}
{CharAnimation("haru_greeter_t03","Listening")}
{ChangeTime(4)}
Terlebih lagi jika pelajar tersebut menjadi bergantung pada media sosial

{ShowArgue(false)}
{ChangeTime(4)}
Yang pada akhirnya akan berimbas pada kecanduan terhadap media sosial.

{CharAnimation("haru_greeter_t03","ShakeHead")}
{ChangeTime(4)}
Hal ini tentu akan mengganggu pola interaksi antar individu di dunia nyata. 

{ChangeScript("2_Argumen3")}