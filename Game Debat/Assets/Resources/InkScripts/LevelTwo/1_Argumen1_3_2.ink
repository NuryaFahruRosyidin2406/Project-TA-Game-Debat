EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL CharAnimation(charName, animationName)
EXTERNAL ChangeTime(timeLeft)
EXTERNAL ShowArgue(argueStatus)
EXTERNAL ChangeScript(scriptName)
EXTERNAL ChoiceTime(timeLeft)
EXTERNAL TransNum(transNumber)
EXTERNAL AddDebateScorePenyampaian(debateScorePenyampaian)

{ChangeTime(0)}
Test

{Name("Budi")}
{Icon("pemain")}
{ChangeTime(4)}
Saya kurang setuju dengan pendapat yang menyatakan,

{ChangeTime(5)}
Bahwa media sosial dapat melemahkan interaksi sosial para pelajar di dunia nyata.

{ChangeTime(4)}
Justru media sosial dapat membangun kepercayaan diri para pelajar 

{ChangeTime(3)}
Yang mungkin tidak mereka miliki di dunia nyata.

{ChangeTime(3)}
Melalui media sosial, para pelajar tersebut bebas untuk berargumentasi 

{ChangeTime(4)}
Dan terlibat dalam kegiatan pembelajaran yang berlangsung pada media sosial. 

{ChangeTime(5)}
Hal tersebut tentu akan menambah kepercayaan diri mereka.

{Name("Farah")}
{Icon("farah")}
{CharAnimation("haru_greeter_t03","Surprised")}
{TransNum(4)}
{ChangeTime(0)}
Interupsi!

{TransNum(0)}
{ChangeTime(2)}
Interupsi!

{ChangeTime(4)}
{ShowArgue(false)}
Media sosial membuat pelajar merasa mampu hanya di dunia maya.

{Name("Budi")}
{Icon("pemain")}
{ChoiceTime(1000)}
{ChangeTime(2)}
(Pilih untuk mempertahankan argumen!) 

* [Memperkuat Interaksi Sosial]
{Name("Budi")}
{Icon("pemain")}
{CharAnimation("haru_greeter_t03","Agree")}
{AddDebateScorePenyampaian(13)}
{ChangeTime(5)}
Para pelajar akan merasa terbantu dalam meningkatkan interaksi sosial agar semakin terjalin kuat.

{ChangeTime(3)}
Media sosial adalah wadah yang bervariasi 

{ChangeTime(5)}
Sehingga tidak sulit untuk menciptakan interaksi dengan orang lain dengan mudah dan cepat.

{ChangeTime(5)}
Interaksi sosial tercipta bukan hanya melalui dunia nyata, akan tetapi juga media sosial.

{ChangeTime(4)}
Besarnya waktu penggunaan media sosial menjadi bukti bahwa

{ChangeTime(3)}
Interaksi sosial yang terjalin juga semakin besar.

{ChangeScript("2_Intro")}

* [Meningkatkan Rasa Percaya Diri]
{Name("Budi")}
{Icon("pemain")}
{CharAnimation("haru_greeter_t03","Agree")}
{AddDebateScorePenyampaian(11)}
{ChangeTime(5)}
Kebebasan berargumentasi di media sosial akan menjadi acuan dalam meningkatkan rasa percaya diri. 

{ChangeTime(3)}
Saat para pelajar mencoba berargumentasi di dunia maya, 

{ChangeTime(4)}
Mereka lebih leluasa untuk berpikir dan bersifat mandiri.

{ChangeTime(3)}
Akan tetapi saat dihadapkan di dunia nyata, 

{ChangeTime(4)}
Kepercayaan diri mereka menjadi lemah dan gugup dalam berinteraksi.

{ChangeTime(6)}
Terbentuknya kepercayaan diri di dunia maya menghantarkan kepercayaan diri yang lebih besar di dunia nyata.

{ChangeScript("2_Intro")}