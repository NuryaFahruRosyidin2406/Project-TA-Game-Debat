EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL CharAnimation(charName, animationName)
EXTERNAL CharExpression(charName, expressionInt)
EXTERNAL ChangeTime(timeLeft)
EXTERNAL ShowArgue(argueStatus)
EXTERNAL ChangeScript(scriptName)
EXTERNAL TransNum(transNumber)
EXTERNAL ChoiceTime(timeLeft)
<<<<<<< Updated upstream
EXTERNAL AddDebateScore(debateScore)

{ChangeTime(0)}
Baiklah, waktu penyampaian argumen sudah habis.

{Name("Moderator")}
{Icon("mc1")}
{ChangeTime(3)}
{AddDebateScore(-5)}
Berhenti!
=======

{ChangeTime(0)}
>>>>>>> Stashed changes

{Name("Moderator")}
{Icon("mc1")}
{ChangeTime(3)}
<<<<<<< Updated upstream
Waktu anda sudah habis.
=======
Baiklah, waktu penyampaian argumen sudah habis.
>>>>>>> Stashed changes

{ChangeScript("3_Penutup")}