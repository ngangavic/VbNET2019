package com.example.ngangavictor.smartforex;

import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class SignInActivity extends AppCompatActivity {

    private EditText mEditTextIDNo;
    private EditText mEditTextPassword;
    private Button mButtonSignIn;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_sign_in);
        mEditTextIDNo = findViewById(R.id.editTextIDNo);
        mEditTextPassword = findViewById(R.id.editTextPassword);
        mButtonSignIn = findViewById(R.id.buttonSignIn);

        mButtonSignIn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                logIn();
            }
        });
    }

    private void logIn(){
        String idNo = mEditTextIDNo.getText().toString();
        String pass = mEditTextPassword.getText().toString();

        if (idNo.isEmpty()){
            //error
            clearEditText();
            mEditTextIDNo.requestFocus();
            mEditTextIDNo.setError("Required");
        }else if (pass.isEmpty()){
            //error
            clearEditText();
            mEditTextPassword.requestFocus();
            mEditTextPassword.setError("Required");
        }else {
            //login
            if (idNo.equals("Issah Mwangome")&&pass.equals("13197859")){
                //go to home
                Intent intent = new Intent(SignInActivity.this,HomeActivity.class);
                startActivity(intent);
                clearEditText();
                finish();
            }else{
                //error alert.
                clearEditText();
                logInAlert();
            }
        }


    }

    private void logInAlert(){
        AlertDialog.Builder builder = new AlertDialog.Builder(SignInActivity.this);
        builder.setCancelable(false);
        builder.setTitle("Error");
        builder.setMessage("You entered wrong credentials. Do you want to try again?");
        builder.setPositiveButton("YES", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                dialog.dismiss();
            }
        });
        builder.setNegativeButton("NO", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                Intent intent = new Intent(SignInActivity.this,VerificationActivity.class);
                startActivity(intent);
            }
        });
        AlertDialog alertDialog = builder.create();
        alertDialog.show();
    }

    private  void clearEditText(){
        mEditTextIDNo.getText().clear();
        mEditTextPassword.getText().clear();
    }


}
