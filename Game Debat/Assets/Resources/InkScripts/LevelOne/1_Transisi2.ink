EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL CharAnimation(charName, animationName)
EXTERNAL CharExpression(charName, expressionInt)
EXTERNAL ChangeTime(timeLeft)
EXTERNAL ShowArgue(argueStatus)
EXTERNAL ChangeScript(scriptName)
EXTERNAL ChoiceTime(timeLeft)
EXTERNAL AddDebateScore(debateScore)

{Name("Fatih")}
{Icon("fatih")}
{CharAnimation("chitose","AgreeWithYou")}
{CharExpression("chitose",0)}
{ChangeTime(0)}
Kalau sudah begini, apakah Anda masih yakin bahwa Ujian Nasional masih efektif untuk menentukan kelulusan seorang siswa?

{Name("Pemain")}
{Icon("pemain")}
{CharAnimation("chitose","AgreeWithYou")}
{CharExpression("chitose",0)}
{ChoiceTime(10)}
{ChangeTime(2)}
{ShowArgue(false)}
(Pilih argumen sanggahan untuk membantah argumen lawan!)

* [Tingkatkan keamanan sistem]
{AddDebateScore(10)}
{ChangeScript("1_Argumen2_1")}

* [Memperbanyak pengawas]
{AddDebateScore(3)}
{ChangeScript("1_Argumen2_2")}

* [Batal Menginterupsi]
{AddDebateScore(0)}
{ChangeScript("1_Argumen2_3")}