package com.example.ngangavictor.smartforex;

import android.content.Context;
import android.content.Intent;
import android.os.CountDownTimer;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.View;
import android.view.inputmethod.InputMethodManager;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.ProgressBar;
import android.widget.TextView;
import android.widget.Toast;

public class VerificationActivity extends AppCompatActivity {

    private EditText mEditTextOne;
    private EditText mEditTextTwo;
    private EditText mEditTextThree;
    private EditText mEditTextFour;
    private LinearLayout mVerificationProgress;
    public int timerCount=0;
    private TextView mTextViewTimer;
    private ProgressBar mProgressBarVerification;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_verification);
        mEditTextOne = findViewById(R.id.editTextOne);
        mEditTextTwo = findViewById(R.id.editTextTwo);
        mEditTextThree = findViewById(R.id.editTextThree);
        mEditTextFour = findViewById(R.id.editTextFour);
        mVerificationProgress = findViewById(R.id.verificationProgress);
        mTextViewTimer = findViewById(R.id.textViewTimer);
        mProgressBarVerification = findViewById(R.id.progressBarVerification);

        mEditTextOne.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence s, int start, int count, int after) {
                mEditTextOne.requestFocus();
            }

            @Override
            public void onTextChanged(CharSequence s, int start, int before, int count) {
                mEditTextTwo.requestFocus();
            }

            @Override
            public void afterTextChanged(Editable s) {

            }
        });

        mEditTextTwo.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence s, int start, int count, int after) {
                mEditTextTwo.requestFocus();
            }

            @Override
            public void onTextChanged(CharSequence s, int start, int before, int count) {
                mEditTextThree.requestFocus();
            }

            @Override
            public void afterTextChanged(Editable s) {

            }
        });

        mEditTextThree.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence s, int start, int count, int after) {
                mEditTextThree.requestFocus();
            }

            @Override
            public void onTextChanged(CharSequence s, int start, int before, int count) {
                mEditTextFour.requestFocus();
            }

            @Override
            public void afterTextChanged(Editable s) {

            }
        });

        mEditTextFour.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence s, int start, int count, int after) {

            }

            @Override
            public void onTextChanged(CharSequence s, int start, int before, int count) {
                closeKeyboard();
                mVerificationProgress.setVisibility(View.VISIBLE);
                String code = "" + mEditTextOne.getText() + mEditTextTwo.getText() + mEditTextThree.getText() + mEditTextFour.getText();
                Toast.makeText(VerificationActivity.this, code, Toast.LENGTH_LONG).show();
                countDown();
            }

            @Override
            public void afterTextChanged(Editable s) {

            }
        });

    }

    private void closeKeyboard() {
        View view = this.getCurrentFocus();
        if (view != null) {
            InputMethodManager inputMethodManager = (InputMethodManager) getSystemService(Context.INPUT_METHOD_SERVICE);
            inputMethodManager.hideSoftInputFromWindow(view.getWindowToken(), 0);
        }
    }

    private void countDown() {
        new CountDownTimer(30000, 1000) {

            @Override
            public void onTick(long millisUntilFinished) {

                timerCount++;
                String time = String.valueOf(timerCount);
                mProgressBarVerification.setProgress((int) (timerCount*3.4));
                mTextViewTimer.setText("00."+time);
            }

            @Override
            public void onFinish() {
                Intent intent = new Intent(VerificationActivity.this,HomeActivity.class);
                startActivity(intent);
                finish();
            }
        }.start();
    }
}
