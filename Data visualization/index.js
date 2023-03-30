/** query selector gets an elements from css file
that matches with a variable being called in javascript 
**/


/** .children retries all the items connected to the parent which is slider-items **/
 var slides=document.querySelector('.slider-items').children; 
/**next is being recalled as the right slide pointer **/
 var nextSlide=document.querySelector(".right-slide");
/**prev is being recalled as the left slide pointer **/
var prevSlide=document.querySelector(".left-slide");

/**total slides is equal to the amount of slides added **/
var totalSlides=slides.length;
/**counts what slider its on **/
var index=0;

/** when the right pointer is clicked it'll move to the next slider**/

nextSlide.onclick=function () {
     next("next");
}

/**when the left pointer is clicked it, it'll move to the previous slider **/
prevSlide.onclick=function () {
     next("prev");
}

/**while loop for the function next which is the (onclick) **/

function next(direction){
/**this loop checks 2 things, the first is:
if the user has clicked on "next", it'll add 1 to the index
secondly it'll check if the index is equal to the total number of slides and if yes it'll show the first slider and te count will go back to 0

**/
   if(direction=="next"){
      index++;
       if(index==totalSlides){
        index=0;
       }
   } 
    
    
    /**if previous is clicked, the index/count will be equal to the total number of slides - 1 as it's going backwards
    **/
   else{
           if(index==0){
            index=totalSlides-1;
           }
           else{
            index--;
           }
    }
    
    
/** here i am stating that index will always start at 0 and it'll stop adding according to the length/ how many slides there are and that is what monitors wherever a number is added onto index or taken away**/
  for(i=0;i<slides.length;i++){
          slides[i].classList.remove("active");
  }
  slides[index].classList.add("active");     

}
