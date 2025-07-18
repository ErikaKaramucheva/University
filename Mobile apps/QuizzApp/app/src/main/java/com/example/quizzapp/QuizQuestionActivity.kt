package com.example.quizzapp

import android.content.Intent
import android.graphics.Color
import android.graphics.Typeface
import android.os.Bundle
import android.view.View
import android.widget.Button
import android.widget.ImageView
import android.widget.ProgressBar
import android.widget.TextView
import androidx.appcompat.app.AppCompatActivity
import androidx.core.content.ContextCompat
import com.example.quizzapp.databinding.ActivityQuizQuestionBinding
import kotlin.random.Random

class QuizQuestionActivity:AppCompatActivity(), View.OnClickListener {

    private lateinit var binding: ActivityQuizQuestionBinding
    private lateinit var progress_bar:ProgressBar
    private lateinit var tv_progress:TextView
    private lateinit var tv_question:TextView
    private lateinit var iv_image :ImageView
    private lateinit var tv_option_one:TextView
    private lateinit var tv_option_two :TextView
    private lateinit var tv_option_three:TextView
    private lateinit var tv_option_four:TextView
    private lateinit var btn_submit:Button

    private var mCurrentPosition:Int=1
    private var mQuestionList:ArrayList<Question>?=null
    private var mSelectedOptionPosition:Int=0
    private var mCorrectAnswers:Int=0
    private var mUserName:String?=null


    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_quiz_question)

        progress_bar = findViewById<ProgressBar>(R.id.progress_bar)
        tv_progress=findViewById<TextView>(R.id.tv_progress)
        tv_question = findViewById<TextView>(R.id.tv_question)
        iv_image = findViewById<ImageView>(R.id.iv_image)
        tv_option_one = findViewById<TextView>(R.id.tv_option_one)
        tv_option_two = findViewById<TextView>(R.id.tv_option_two)
        tv_option_three = findViewById<TextView>(R.id.tv_option_three)
        tv_option_four = findViewById<TextView>(R.id.tv_option_four)
        btn_submit = findViewById<Button>(R.id.btn_submit)


        mUserName=intent.getStringExtra(Constants.USER_NAME)


       // mQuestionList = Constants.getQuestions();
        chooseQuestions()
        setQuestion()
        tv_option_one.setOnClickListener(this)
        tv_option_two.setOnClickListener(this)
        tv_option_three.setOnClickListener(this)
        tv_option_four.setOnClickListener(this)
        btn_submit.setOnClickListener(this)

        //Log.i("Question Size", "${mQuestionList.size}")

    }
    private fun chooseQuestions(){
        var questionList=Constants.getQuestions()
        if(questionList.size==0){
            tv_question.text="Sorry, Something went wrong. Please, try again later!"
            finish()
        }
        if (questionList.size >= 10) {
            val random = Random.Default
            val indices = mutableSetOf<Int>()
            while (indices.size < 10) {
                val randomIndex = random.nextInt(questionList.size)
                indices.add(randomIndex)
            }
            mQuestionList = ArrayList(indices.map { questionList[it] })

        } else {
            mQuestionList = ArrayList(questionList)
        }
        if(mQuestionList?.size==0){
           mQuestionList=ArrayList(mQuestionList?.subList(1,10))
        }
    }

    private fun setQuestion(){

        val question=mQuestionList!![mCurrentPosition-1]

        defaultOptionsView()
        if(mCurrentPosition==mQuestionList!!.size){
            btn_submit.text="FINISH"
        }else{
            btn_submit.text="SUBMIT"
        }

        progress_bar.progress=mCurrentPosition
        tv_progress.text="$mCurrentPosition"+"/"+progress_bar.max
        tv_question.text=question!!.question
        iv_image.setImageResource(question.image)
        tv_option_one.text=question.optionOne
        tv_option_two.text=question.optionTwo
        tv_option_three.text=question.optionThree
        tv_option_four.text=question.optionFour


    }

    private fun defaultOptionsView(){
        val options=ArrayList<TextView>()
        options.add(0,tv_option_one)
        options.add(1,tv_option_two)
        options.add(2,tv_option_three)
        options.add(3,tv_option_four)

        for(option in options){
            option.setTextColor(Color.parseColor("#7A8089"))
            option.typeface= Typeface.DEFAULT
            option.background= ContextCompat.getDrawable(this,
                R.drawable.default_option_border_bg)
        }
    }

    override fun onClick(p0: View?) {
        when (p0?.id) {
            R.id.tv_option_one -> {
                selectedOptionView(tv_option_one, selectedOptionNum = 1)
            }

            R.id.tv_option_two -> {
                selectedOptionView(tv_option_two, selectedOptionNum = 2)
            }

            R.id.tv_option_three -> {
                selectedOptionView(tv_option_three, selectedOptionNum = 3)
            }

            R.id.tv_option_four -> {
                selectedOptionView(tv_option_four, selectedOptionNum = 4)
            }

            R.id.btn_submit -> {
                if(mSelectedOptionPosition==0){
                    mCurrentPosition++

                    when{
                        mCurrentPosition<=mQuestionList!!.size->{
                            setQuestion()
                        }else->{
                            val intent= Intent(this,ResultActivity::class.java)
                        intent.putExtra(Constants.USER_NAME,mUserName)
                        intent.putExtra(Constants.CORRECT_ANSWERS,mCorrectAnswers)
                        intent.putExtra(Constants.TOTAL_QUESTIONS,mQuestionList!!.size)
                        startActivity(intent)
                        finish()

                        }
                    }
                }else{
                    val question=mQuestionList?.get(mCurrentPosition-1)
                    if(question!!.correctAnswer!=mSelectedOptionPosition){
                        answerView(mSelectedOptionPosition,R.drawable.wrong_option_border_bg)
                    }else{
                        mCorrectAnswers++
                    }
                    answerView(question.correctAnswer, R.drawable.correct_option_border_bg)
                    if(mCurrentPosition==mQuestionList!!.size){
                        btn_submit.text="FINISH"
                    }else{
                        btn_submit.text="GO TO NEXT QUESTION"
                    }
                    mSelectedOptionPosition=0
                }
            }

        }
    }
        private fun answerView(answer:Int, drawableView:Int){
            when(answer){
                1->{
                    tv_option_one.background=ContextCompat.getDrawable(this,drawableView)
                }
                2->{
                    tv_option_two.background=ContextCompat.getDrawable(this,drawableView)
                }
                3->{
                    tv_option_three.background=ContextCompat.getDrawable(this,drawableView)
                }
                4->{
                    tv_option_four.background=ContextCompat.getDrawable(this,drawableView)
                }


            }
        }




    private fun selectedOptionView(tv:TextView, selectedOptionNum:Int){
        defaultOptionsView()
mSelectedOptionPosition=selectedOptionNum
        tv.setTextColor(Color.parseColor("#9013FE"))
        tv.setTypeface(tv.typeface, Typeface.BOLD)
        tv.background= ContextCompat.getDrawable(this,
            R.drawable.default_option_border_bg)

    }



}
