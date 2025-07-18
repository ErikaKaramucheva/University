package com.example.quizzapp

object Constants {

    const val USER_NAME:String="user_name"
    const val TOTAL_QUESTIONS:String="total_question"
    const val CORRECT_ANSWERS:String="correct_answers"

    fun getQuestions(): ArrayList<Question> {
        val QuestionList = ArrayList<Question>()
        val que1 = Question(
            1,
            "What country does this flag belongs to?",
            R.drawable.bg_flag,
            "Italy",
            "Bulgaria",
            "China",
            "Greece",
            2
        )
        val que2 = Question(
            2,
            "What country does this flag belongs to?",
            R.drawable.it_flag,
            "Bulgaria",
            "Switzerland",
            "Italy",
            "Turkey",
            3
        )
        val que3 = Question(
            3,
            "What country does this flag belongs to?",
            R.drawable.id_flag,
            "China",
            "India",
            "Spain",
            "Turkey",
            2
        )
        val que4 = Question(
            4,
            "What country does this flag belongs to?",
            R.drawable.pk_flag,
            "Bangladesh",
            "Switzerland",
            "Turkey",
            "Pakistan",
            4
        )
        val que5 = Question(
            5,
            "What country does this flag belongs to?",
            R.drawable.sk_flag,
            "South Korea",
            "South Africa",
            "Chile",
            "Denmark",
            1
        )
        val que6 = Question(
            6,
            "What country does this flag belongs to?",
            R.drawable.mb,
            "Russia",
            "India",
            "Mozambique",
            "Brazil",
            3
        )
        val que7 = Question(
            7,
            "What country does this flag belongs to?",
            R.drawable.eg_flag,
            "Portugal",
            "Monaco",
            "Bangladesh",
            "Egypt",
            4
        )
        val que8 = Question(
            8,
            "What country does this flag belongs to?",
            R.drawable.cl_flag,
            "Ukraine",
            "Colombia",
            "Ghana",
            "Costa Rica",
            2
        )
        val que9 = Question(
            9,
            "What country does this flag belongs to?",
            R.drawable.qt_flag,
            "Poland",
            "Switzerland",
            "Qatar",
            "New Zealand",
            3
        )
        val que10 = Question(
            10,
            "What country does this flag belongs to?",
            R.drawable.rm_flag,
            "Poland",
            "Romania",
            "Moldova",
            "Andorra",
            2
        )
        val que11 = Question(
            11,
            "What country does this flag belongs to?",
            R.drawable.hg_flag,
            "Hungary",
            "Spain",
            "Austria",
            "Andorra",
            1
        )
        val que12 = Question(
            12,
            "What country does this flag belongs to?",
            R.drawable.latvia,
            "Qatar",
            "Austria",
            "Latvia",
            "Litva",
            3
        )
        val que13 = Question(
            13,
            "What country does this flag belongs to?",
            R.drawable.ch_flag,
            "China",
            "Litva",
            "Israel",
            "Malta",
            1
        )
        val que14 = Question(
            14,
            "What country does this flag belongs to?",
            R.drawable.tw_flag,
            "Serbia",
            "Malta",
            "Taiwan",
            "Brazil",
            3
        )
        val que15 = Question(
            15,
            "What country does this flag belongs to?",
            R.drawable.isr_flag,
            "Chile",
            "Pakistan",
            "Israel",
            "Greece",
            3
        )
        val que16 = Question(
            16,
            "What country does this flag belongs to?",
            R.drawable.lbn_flag,
            "Greece",
            "Lebanon",
            "Vatican",
            "Spain",
            2
        )
        val que17 = Question(
            17,
            "What country does this flag belongs to?",
            R.drawable.tns_flag,
            "Pakistan",
            "Moldova",
            "China",
            "Tunisia",
            4
        )
        val que18 = Question(
            18,
            "What country does this flag belongs to?",
            R.drawable.pr_flag,
            "Peru",
            "Latvia",
            "Mozambique",
            "Malta",
            1
        )
        val que19 = Question(
            19,
            "What country does this flag belongs to?",
            R.drawable.nrtmc_flag,
            "Botswana",
            "Eqypt",
            "North Macedonia",
            "Vatican",
            3
        )
        val que20 = Question(
            20,
            "What country does this flag belongs to?",
            R.drawable.srb_flag,
                "Serbia",
            "Bosnia and Herzegovina",
            "Argentina",
            "Croatia",
            1
        )
        val que21 = Question(
            21,
            "What country does this flag belongs to?",
            R.drawable.ast_flag,
            "Australia",
            "Adorra",
            "Moldova",
            "Austria",
            4
        )
        val que22 = Question(
            22,
            "What country does this flag belongs to?",
            R.drawable.tk_flag,
            "Mongolia",
            "Bosnia and Herzegovina",
            "Turkey",
            "China",
            3
        )
        val que23 = Question(
            23,
            "What country does this flag belongs to?",
            R.drawable.vtc_flag,
            "Taiwan",
            "Syria",
            "Vatican",
            "Israel",
            3
        )
        val que24 = Question(
            24,
            "What country does this flag belongs to?",
            R.drawable.gr_flag,
            "Serbia",
            "Greece",
            "Israel",
            "Tunisia",
            2
        )
        val que25 = Question(
            25,
            "What country does this flag belongs to?",
            R.drawable.fj_flag,
            "Fiji",
            "Australia",
            "Greece",
            "Marocco",
            1
        )




        QuestionList.add(que1)
        QuestionList.add(que2)
        QuestionList.add(que3)
        QuestionList.add(que4)
        QuestionList.add(que5)
        QuestionList.add(que6)
        QuestionList.add(que7)
        QuestionList.add(que8)
        QuestionList.add(que9)
        QuestionList.add(que10)
        QuestionList.add(que11)
        QuestionList.add(que12)
        return QuestionList
    }
}



