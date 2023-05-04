string user_input = Console.ReadLine();
Console.WriteLine(user_input);
int left_index = 0;
int right_index = user_input.Length - 1;
bool is_pal = true;
while (left_index < right_index){
    if(user_input[left_index] != user_input[right_index]){
        is_pal = false;
        break;
    }
    left_index++;
    right_index--;
}
if(is_pal){
    Console.WriteLine("yup.");
}
else{
    Console.WriteLine("no.");
}
