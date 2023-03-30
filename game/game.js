//stores all the questions

var q = ["Which word is the name of a fruit?<br /><br />", "What is 2 + 2?<br /><br />"];

//options 1 and 2 for each question
//options are separated by button, there are only 2 buttons (choices)
//var answer 1 where all the answers for button 1 are stored

        var answer1 = ["<button class=answer onclick=q1c()>apple</button>",
                  "<button class=answer onclick=q2c()>4</button>"];
//var answer 1 where all the answers for button 2 are stored
        var answer2 = ["<button class=answer onclick=q1i()>car</button>",
                  "<button class=answer onclick=q2i()>7</button>"];

     
//stores the message correct 
        var c = ["Correct", "Correct"];

//incorrect message incorrect
        var i = ["Incorrect", "Incorrect"];
//question count starting at 0
        var n = 0;

        n++;
//score count
        var s = 0;
        s++;

//new question
        function startgame() {
            hide.innerHTML = "";
            start.innerHTML = "";
            questionNo.innerHTML = q[0];
            option1.innerHTML = answer1[0];
            option2.innerHTML = answer2[0];
            qNumber.innerHTML = n++;
        }

//sets question 1 ,answer 1 to correct
//this function goes to question 1 position [0] then goes to var answer 1 position [0] and goes to var c position[0]
//function q1i does the exact same however it goes to var answer 1 position [0] and also var i position [0]
        function q1c() {
            //if correct answers , message correct answer is green
            answer.innerHTML = "<div id=correctAnswer>" + c[0] + "</div>";
            
            //options
            option1.innerHTML = "";
            option2.innerHTML = "";
            //next question
            nextQ.innerHTML = "<button class=mainButton onclick=new002()>Next</button>";
            
            //increments the score to plus 1 when answer correct
            sNumber.innerHTML = s++;
        }
//question 1 incorrect
        function q1i() {
            //if wrong answer a message will display saying incorrect in red
            answer.innerHTML = "<div id=wrongAnswer>" + i[0] + "</div>";
            //options
            option1.innerHTML = "";
            option2.innerHTML = "";
            //next question
            
            //when next button clicked it passes to the next function which is a new question
            nextQ.innerHTML = "<button class=mainButton onclick=new002()>Next</button>";
        }

      
        function new002() {
            questionNo.innerHTML = q[1];
            option1.innerHTML = answer1[1];
            option2.innerHTML = answer2[1];
            nextQ.innerHTML = "";
            answer.innerHTML = "";
            
            //because it's a new question, it increments the question number up once 
            qNumber.innerHTML = n++;
        }

        function q2c() {
            answer.innerHTML = "<div id=correctAnswer>" + c[1] + "</div>";
            option1.innerHTML = "";
            option2.innerHTML = "";
            nextQ.innerHTML = "<button class=mainButton onclick=q2i()>Next</button>";
            sNumber.innerHTML = s++;
        }

        function q2i() {
            
            
            answer.innerHTML = "<div id=wrongAnswer>" + i[1] + "</div>";
            option1.innerHTML = "";
            option2.innerHTML = "";
            //because it's the last question , instead of next there is a finish button
            nextQ.innerHTML = "<button class=mainButton onclick=end()>finish</button>";
        }

        
 //greets the user for a good attempt, display end number of questions and also their points 


        function end() {
            start.innerHTML = " Well done! Good attempt, this is the end of the game try again by clicking the repeat button";
            questionNo.innerHTML = "";
            option1.innerHTML = "";
            option2.innerHTML = "";
            
            //button repeat
            nextQ.innerHTML = "<div id=maiButton>" + "<button class=repeat onclick=repeat()>Repeat</button>" + "</div>";
            answerQ.innerHTML = "";
        }
//function that reloads the page
        function repeat() {
            location.reload();
        }

