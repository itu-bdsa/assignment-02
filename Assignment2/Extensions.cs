namespace Assignment2;

public static class Extensions
{

public static bool isSecure(this Uri uri){ 
return uri.Scheme==Uri.UriSchemeHttps;
}

public static int wordCount(this String count){
    bool isLetter=count.All(Char.IsLetter);
        int c=0;

        for(int i=0; i<count.Length-1; i++){
            if(count[i]==' ' && char.IsLetter(count[i+1]) && (i>0)){
                c++;
            }
        }
        c++;
        return c;

}
}
