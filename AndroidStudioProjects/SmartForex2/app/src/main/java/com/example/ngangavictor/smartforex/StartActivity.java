package com.example.ngangavictor.smartforex;

import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Build;
import android.os.Bundle;
import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ProgressBar;

public class StartActivity extends AppCompatActivity {
    private Button mButtonSignIn;
    private Button mButtonSubmit;
    private EditText mEditTextID;
    private EditText mEditTextMobile;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_start);
        mButtonSignIn = findViewById(R.id.buttonSignIn);
        mButtonSubmit = findViewById(R.id.buttonSubmit);
        mEditTextID = findViewById(R.id.editTextID);
        mEditTextMobile = findViewById(R.id.editTextMobile);

        mButtonSignIn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(StartActivity.this, SignInActivity.class);
                startActivity(intent);
                finish();
            }
        });

        mButtonSubmit.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                validate();
            }
        });
    }

    private void validate() {
        String idNo = mEditTextID.getText().toString();
        String mobile = mEditTextMobile.getText().toString();
        if (idNo.isEmpty()) {
            //cannot be empty
            mEditTextID.requestFocus();
            mEditTextID.setError("Cannot be empty");
        } else if (mobile.isEmpty() || Integer.parseInt(mobile) < 10) {
            //cannot be empty
            mEditTextMobile.getText().clear();
            mEditTextMobile.requestFocus();
            mEditTextMobile.setError("Wrong format");
        } else {

            ProgressBar p = new ProgressBar(this);
            AlertDialog.Builder alertDialogBuilder = new AlertDialog.Builder(this);
            alertDialogBuilder.setCancelable(false);
            if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.LOLLIPOP) {
                alertDialogBuilder.setView(R.layout.custom_alert);
            } else {
                alertDialogBuilder.setView(p);
                alertDialogBuilder.setMessage("Verifying Code");
            }
            AlertDialog alertDialog = alertDialogBuilder.create();
            alertDialog.show();
            userDetails(alertDialog);


        }

    }

    private void userDetails(final AlertDialog alertDialog) {
        final AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.setCancelable(false);
        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.LOLLIPOP) {
            builder.setView(R.layout.custom_user_details);
        } else {
            builder.setMessage("Name: Test User \n ID No: 35766392 \n Location: Kilifi County \n Phone: +254 700352822");
        }
        builder.setNegativeButton("No", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                dialog.dismiss();
            }
        });
        builder.setPositiveButton("Yes", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                Intent intent = new Intent(StartActivity.this, VerificationActivity.class);
                startActivity(intent);
            }
        });
        Handler handler = new Handler();
        handler.postDelayed(new Runnable() {
            @Override
            public void run() {
                clearEditText();
                alertDialog.cancel();
                builder.show();
            }
        }, 5000);
    }

    private void clearEditText() {
        mEditTextID.getText().clear();
        mEditTextMobile.getText().clear();
    }

}
