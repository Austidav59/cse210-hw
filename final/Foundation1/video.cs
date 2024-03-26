public class Video
{
    public List<string>_title = new List<string>();
    public List<float>_length = new List<float>();
    public List<string>_author = new List<string>();

    
    public void DisplayVideo()
    {
        // intintialize comments
        Comments comment1 = new Comments();

        // Add to comment lists
        comment1._text1.Add("Great Video!");
        comment1._text1.Add("interesting");
        comment1._text1.Add("cool");
        // vidoe text 2
        comment1._text2.Add("right on!");
        comment1._text2.Add("this is a good video");
        comment1._text2.Add("Trump 2024");
        // 3rd video
        comment1._text3.Add("Trump for president");
        comment1._text3.Add("mr beast is the best");
        comment1._text3.Add("yay");
        //4th video text
        comment1._text4.Add("love it");
        comment1._text4.Add("yes sir");
        comment1._text4.Add("yes video");

        // author
        comment1._authorName.Add("jake34");
        comment1._authorName.Add("halfre_dude");
        comment1._authorName.Add("Soccer_guy5600");
        comment1._authorName.Add("toased waffles");


        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine("");
            Console.WriteLine($"Title: {_title[i]}");
            Console.WriteLine($"Author: {_author[i]}");
            Console.WriteLine($"Length: {_length[i]} Miniutes");
            //Display Comments
            if (i == 0)
            {
                for (int comment = 0; comment < 3; comment++)
                {
                    Console.WriteLine($"{comment + 1}. {comment1._text1[comment]}, {comment1._authorName[comment]} ");
                }
            }
            else if (i == 1)
            {
                for (int comment = 0; comment < 3; comment++)
                {
                    Console.WriteLine($"{comment + 1}. {comment1._text2[comment]}, {comment1._authorName[comment]} ");
                }
            }
            else if (i == 2)
            {
                for (int comment = 0; comment < 3; comment++)
                {
                    Console.WriteLine($"{comment + 1}. {comment1._text3[comment]}, {comment1._authorName[comment]} ");
                }
            }
            else
            {
                for (int comment = 0; comment < 3; comment++)
                {
                    Console.WriteLine($"{comment + 1}. {comment1._text4[comment]}, {comment1._authorName[comment]} ");
                }
            }

            
            
            
            


        }








    }
}