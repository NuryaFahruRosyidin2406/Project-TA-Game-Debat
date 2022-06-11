EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL CharAnimation(charName, animationName)
EXTERNAL CharExpression(charName, expressionInt)
EXTERNAL ChangeTime(timeLeft)
EXTERNAL ShowArgue(argueStatus)
EXTERNAL ChangeScript(scriptName)
EXTERNAL ChoiceTime(timeLeft)
EXTERNAL AddDebateScore(debateScore)

{ChangeTime(0)}
Test

{Name("Pemain")}
{Icon("pemain")}
{ChangeTime(5)}
Saya masih menganggap Ujian Nasional menjadi penentu kelulusan yang efektif terlepas dari kecurangan yang terjadi.

{ChangeTime(5)}
Apabila berbicara tentang kecurangan, menurut saya di mana-mana pasti akan ada kecurangan.

{ChangeTime(3)}
Akan tetapi, bukan berarti hal tersebut tidak dapat di minimalisasi. 

{ChangeTime(5)}
Pemerintah telah menggunakan Ujian Nasional berbasis komputer yang dapat menekan angka kecurangan tersebut.

{ChangeTime(3)}
Selain itu, Ujian Nasional juga masih tetap dibutuhkan. 

{ChangeTime(5)}
Hal ini diperlukan agar siswa tetap mau belajar dan berusaha, serta tidak bersikap acuh tak acuh terhadap pelajaran di sekolah.

{ChangeTime(3)}
Melalui Ujian Nasional, siswa juga dapat mengukur potensi dirinya.

{Name("Fatih")}
{Icon("fatih")}
{CharAnimation("chitose","AgreeWithYou")}
{CharExpression("chitose",0)}
{ChangeTime(4)}
Potensi ini dapat di ukur menggunakan UTS dan UAS, tidak perlu UN

{Name("Pemain")}
{Icon("pemain")}
{ChoiceTime(1000)}
{ChangeTime(2)}
(Pilih untuk mempertahankan argumen!) 

* [UTS dan UAS Tidak Berstandar Nasional]
{AddDebateScore(5)}
{Name("Pemain")}
{Icon("pemain")}
{CharAnimation("chitose","AgreeWithYou")}
{CharExpression("chitose",1)}
{ChangeTime(3)}
UTS dan UAS di setiap sekolah akan berbeda beda.

{ChangeTime(3)}
Sehingga tidak dapat menjadi jaminan sebagai standar nasional yang baik

{ChangeScript("2_Transisi1_2")}

* [UTS dan UAS Tidak Dapat Digunakan]
{AddDebateScore(-2)}
{Name("Pemain")}
{Icon("pemain")}
{CharAnimation("chitose","AgreeWithYou")}
{CharExpression("chitose",1)}
{ChangeTime(3)}
UTS dan UAS merupakan tolak ukur kemampuan belajar dalam satu semester. 

{ChangeTime(3)}
Hal ini tidak bisa digunakan sebagai pengukur potensi diri

{ChangeScript("2_Transisi1_2")}