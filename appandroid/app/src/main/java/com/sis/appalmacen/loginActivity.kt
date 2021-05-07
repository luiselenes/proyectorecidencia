package com.sis.appalmacen

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.Toast


class loginActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_login)

        val textemail = findViewById<EditText>(R.id.textInputCorreo)
        val textcontraseña = findViewById<EditText>(R.id.textInputPassword)
        val loginboton = findViewById<Button>(R.id.btnLogin)


        loginboton.setOnClickListener {
            val showSigned = signIn(textemail.text.toString(), textcontraseña.text.toString())
            if(showSigned){
                Toast.makeText(this, "Iniciando sesión", Toast.LENGTH_SHORT).show()
                val intento2 = Intent(this, activityAlmacenista::class.java)
                startActivity(intento2)
            }else{
                Toast.makeText(this, "Complete los campos", Toast.LENGTH_SHORT).show()
            }

        }
    }
    private fun signIn(textemail: String, textcontraseña: String): Boolean{
        return  textemail.isNotEmpty() && textcontraseña.isNotEmpty()
    }


}