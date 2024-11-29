using UnityEngine;
using UnityEngine.UI;

public class PasswordChecker : MonoBehaviour
{
    // Variável para armazenar a senha correta
    [SerializeField] private string correctPassword = "1234";

    // Variável para armazenar a entrada do usuário
    private string userInput = "";
    public GameObject painel;
    public bool hasCard = false;

    // Referência ao texto na UI para exibir a entrada do usuário (opcional)
    [SerializeField] private Text displayText;

    public void SetHasCard(bool n)
    {
        hasCard = n;
    }
    public void showPainel(){
        if(hasCard)
        painel.SetActive(true);
    }

    // Função chamada ao clicar no botão
    public void AddDigit(string digit)
    {
        // Adiciona o dígito clicado à entrada do usuário
        userInput += digit;

        // Atualiza o texto na UI, se existir
        if (displayText != null)
        {
            displayText.text = userInput;
        }

        // Verifica se a entrada do usuário coincide com a senha correta
        CheckPassword();
    }

    private void CheckPassword()
    {
        if (userInput.Length >= correctPassword.Length)
        {
            if (userInput == correctPassword)
            {
                Debug.Log("Senha correta!");
                // Adicione aqui ações para quando a senha estiver correta
            }
            else
            {
                Debug.Log("Senha incorreta!");
                // Reseta a entrada do usuário
                userInput = "";

                // Atualiza o texto na UI, se existir
                if (displayText != null)
                {
                    displayText.text = userInput;
                }
            }
        }
    }
}
