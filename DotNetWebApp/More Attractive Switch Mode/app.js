// Selecting all the required classes from HTML to change 
var body = document.body
var check = document.querySelector('#check')
var box = document.querySelector('.box')
var ball = document.querySelector('.ball')


// Targeting my social media links********************
var youtube = document.querySelector('.youtube')
var instagram = document.querySelector('.instagram')
// *******************************


// Adding an eventListener function to change color everytime var check is changed.(checked & unchecked)

check.addEventListener('change',function(){

  //   conditions to apply when checkbox is checked

  if(this.checked == true){
    box.setAttribute('style','background-color:white;')
    ball.setAttribute('style','transform:translatex(100%);')
    body.setAttribute('style','background-color:black; color:white;') 




    // Targeting my social media links********************
    youtube.setAttribute('style','border:2px solid white;')
    instagram.setAttribute('style','border:2px solid white;')
    // *******************************

  }

  //   conditions to apply when checkbox is unchecked

  if(this.checked == false){
    box.setAttribute('style','background-color:black; color:white;')
    ball.setAttribute('style','transform:translatex(0%);')
    body.setAttribute('style','background-color:white; color:black;')




    // Targeting my social media links********************
    youtube.setAttribute('style','border:2px solid black; color:black;')
    instagram.setAttribute('style','border:2px solid black;')
    // *******************************


  }
})
